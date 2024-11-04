using Datos.Models;
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
    public partial class specialityList : Form
    {
        public specialityList()
        {
            InitializeComponent();
        }
        private void specialities_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private async void GetAllAndLoad()
        {
            var specialities = await SpecialityApiClient.GetSpecialitiesAsync();


            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = specialities.ToList();

            if (this.dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.Rows[0].Selected = true;
                this.deleteButton.Enabled = true;
                this.updateButton.Enabled = true;
            }
            else
            {
                this.deleteButton.Enabled = false;
                this.updateButton.Enabled = false;
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            specialityForm specialityForm = new specialityForm();
            Especialidade newSpeciality = new Especialidade();
            specialityForm.Speciality = newSpeciality;
            specialityForm.ShowDialog();
            this.GetAllAndLoad();
        }
        private async void updateButton_Click(object sender, EventArgs e)
        {
            specialityForm specialityForm = new specialityForm();
            int id;
            id = this.SelectedItem().IdEspecialidad;

            Especialidade speciality = await SpecialityApiClient.GetSpecialityAsync(id);

            specialityForm.EditMode = true;
            specialityForm.Speciality = speciality;

            specialityForm.ShowDialog();

            this.GetAllAndLoad();
        }
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;
            id = this.SelectedItem().IdEspecialidad;

            await SpecialityApiClient.DeleteAsync(id);
            this.GetAllAndLoad();
        }
        private Especialidade SelectedItem()
        {
            Especialidade speciality;

            speciality = (Especialidade)dataGridView1.SelectedRows[0].DataBoundItem;

            return speciality;
        }
    }
}
