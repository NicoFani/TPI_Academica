using Datos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.Clients;

namespace UI.Desktop
{
    public partial class comissionsList : Form
    {
        public comissionsList()
        {
            InitializeComponent();
        }
        private void Comissions_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            try
            {
                var comissions = await ComissionApiClient.GetComissionsAsync();
                comissionDataGridView.DataSource = comissions;

                if (comissionDataGridView.Rows.Count > 0)
                {
                    comissionDataGridView.Rows[0].Selected = true;
                    deleteButton.Enabled = true;
                    updateButton.Enabled = true;
                }
                else
                {
                    deleteButton.Enabled = false;
                    updateButton.Enabled = false;
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Error al cargar las comisiones: {httpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Detalles del error HTTP: {httpEx}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Detalles del error: {ex}");
            }
        }





        private void addButton_Click(object sender, EventArgs e)
        {
            comissionsForm comissionForm = new comissionsForm();
            Comissions newComission = new Comissions();
            comissionForm.Comission = newComission;
            comissionForm.ShowDialog();
            this.GetAllAndLoad();
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            comissionsForm comissionForm = new comissionsForm();
            int id;
            id = this.SelectedItem().id_comision;

            Comissions comission = await ComissionApiClient.GetComissionAsync(id);

            comissionForm.EditMode = true;
            comissionForm.Comission = comission;

            comissionForm.ShowDialog();

            this.GetAllAndLoad();
        }
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().id_comision;
            await ComissionApiClient.DeleteAsync(id);
            this.GetAllAndLoad();
        }

        private Comissions SelectedItem()
        {
            Comissions comission;

            comission = (Comissions)comissionDataGridView.SelectedRows[0].DataBoundItem;

            return comission;
        }
    }
}
