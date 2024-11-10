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
using Datos.Models;

namespace UI.Desktop
{
    public partial class materiasList : Form
    {
        private IEnumerable<Materia> _materias;
        public materiasList()
        {
            InitializeComponent();
        }
        private void Materias_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private async void GetAllAndLoad()
        {
            try
            {
                _materias = await MateriasApiClient.GetMateriasAsync();
                dataGridView1.DataSource = _materias.Select(m => new {
                    idMateria = m.IdMateria,
                    descMateria = m.DescMateria,
                    hsSemanales = m.HsSemanales,
                    hsTotales = m.HsTotales,
                    Plan = m.IdPlanNavigation?.DescPlan
                }).ToList();
                dataGridView1.Columns["idMateria"].Visible = false;

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
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
                MessageBox.Show($"Error al cargar las materias: {httpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            materiasForm materiaForm = new materiasForm();
            Materia newMateria = new Materia();
            materiaForm.Materia = newMateria;
            materiaForm.ShowDialog();
            this.GetAllAndLoad();
        }
        private async void updateButton_Click(object sender, EventArgs e)
        {
            materiasForm materiaForm = new materiasForm();
            int id;
            id = this.SelectedItem().IdMateria;

            Materia materia = await MateriasApiClient.GetMateriaAsync(id);

            materiaForm.EditMode = true;
            materiaForm.Materia = materia;

            materiaForm.ShowDialog();
            this.GetAllAndLoad();
        }
        private async void deleteButton_Click (object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().IdMateria;
            await MateriasApiClient.DeleteAsync(id);
            this.GetAllAndLoad();
        }
        private Materia SelectedItem()
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = (int)row.Cells["idMateria"].Value;
            Materia materia = _materias.First(m => m.IdMateria == id);
            return materia;
        }
    }
}
