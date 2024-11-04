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
    public partial class cursosList : Form
    {
        public cursosList()
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
                var cursos = await CursosApiClient.GetCursosAsync();
                dataGridView1.DataSource = cursos;

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
                MessageBox.Show($"Error al cargar los cursos: {httpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cursosForm cursoForm = new cursosForm();
            Curso newCurso = new Curso();
            cursoForm.Curso = newCurso;
            cursoForm.ShowDialog();
            this.GetAllAndLoad();
        }
        private async void updateButton_Click(object sender, EventArgs e)
        {
            cursosForm cursoForm = new cursosForm();
            int id;
            id = this.SelectedItem().IdCurso;

            Curso curso = await CursosApiClient.GetCursoAsync(id);

            cursoForm.EditMode = true;
            cursoForm.Curso = curso;

            cursoForm.ShowDialog();
            this.GetAllAndLoad();
        }
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().IdCurso;

            await CursosApiClient.DeleteAsync(id);
            this.GetAllAndLoad();
        }
        private Curso SelectedItem()
        {
            Curso curso;

            curso = (Curso)dataGridView1.SelectedRows[0].DataBoundItem;

            return curso;
        }
    }
}
