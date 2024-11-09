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
    public partial class docentesCursosList : Form
    {
        public docentesCursosList()
        {
            InitializeComponent();
        }
        private void DocentesCursos_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private async void GetAllAndLoad()
        {
            try
            {
                var docentesCursos = await DocentesCursosApiClient.GetDocentesCursosAsync();
                dataGridView1.DataSource = docentesCursos;

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
                MessageBox.Show($"Error al cargar los docentes y cursos: {httpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Detalles del error HTTP: {httpEx}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Detalles del error: {ex}");
            }
        }
        public void addButton_Click(object sender, EventArgs e)
        {
            docentesCursosForm docenteCursoForm = new docentesCursosForm();
            DocentesCurso newdocenteCurso = new DocentesCurso();
            docenteCursoForm.DocenteCurso = newdocenteCurso;
            docenteCursoForm.ShowDialog();
            this.GetAllAndLoad();
        }
        private async void updateButton_Click(object sender, EventArgs e)
        {
            docentesCursosForm docenteCursoForm = new docentesCursosForm();
            int id;
            id = this.SelectedItem().IdDictado;

            DocentesCurso docenteCurso = await DocentesCursosApiClient.GetDocenteCursoAsync(id);

            docenteCursoForm.EditMode = true;
            docenteCursoForm.DocenteCurso = docenteCurso;

            docenteCursoForm.ShowDialog();
            this.GetAllAndLoad();
        }
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().IdDictado;

            await DocentesCursosApiClient.DeleteAsync(id);
            this.GetAllAndLoad();
        }
        private DocentesCurso SelectedItem()
        {
            DocentesCurso docenteCurso;

            docenteCurso = (DocentesCurso)dataGridView1.SelectedRows[0].DataBoundItem;

            return docenteCurso;
        }
    }
}