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
    public partial class InscripcionesList : Form
    {
        private IEnumerable<AlumnosInscripcione> _inscripciones;
        public InscripcionesList()
        {
            InitializeComponent();
        }
        private void Inscripciones_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private async void GetAllAndLoad()
        {
            try
            {
                _inscripciones = await AlumnosInscripcionesApiClient.GetAlumnosInscripcionesAsync();
                dataGridView1.DataSource = _inscripciones.Select(insc => new {
                    idInscripcion = insc.IdInscripcion,
                    Alumno = $"{insc.IdAlumnoNavigation!.Apellido}, {insc.IdAlumnoNavigation.Nombre}",
                    LegajoAlumno = insc.IdAlumnoNavigation.Legajo,
                    Condicion = insc.Condicion,
                    Nota = insc.Nota,
                    Materia = insc.IdCursoNavigation!.IdMateriaNavigation!.DescMateria,
                    Comision = insc.IdCursoNavigation!.IdComisionNavigation!.DescComision,
                    Plan = insc.IdCursoNavigation!.IdMateriaNavigation!.IdPlanNavigation!.DescPlan,
                    Especialidad = insc.IdCursoNavigation!.IdMateriaNavigation!.IdPlanNavigation!.IdEspecialidadNavigation!.DescEspecialidad
                }).ToList();
                dataGridView1.Columns["idInscripcion"].Visible = false;
                dataGridView1.Columns["LegajoAlumno"].HeaderText = "Legajo Alumno";
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
                MessageBox.Show($"Error al cargar las inscripciones: {httpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            InscripcionesForm inscripcionesForm = new InscripcionesForm();
            AlumnosInscripcione newAlumnosInscripcione = new AlumnosInscripcione();
            inscripcionesForm.AlumnosInscripcione = newAlumnosInscripcione;
            inscripcionesForm.ShowDialog();
            this.GetAllAndLoad();
        }
        private async void updateButton_Click(object sender, EventArgs e)
        {
            InscripcionesForm inscripcionesForm = new InscripcionesForm();
            int id;
            id = this.SelectedItem().IdInscripcion;

            AlumnosInscripcione inscripciones = await AlumnosInscripcionesApiClient.GetAlumnosInscripcionesAsync(id);

            inscripcionesForm.EditMode = true;
            inscripcionesForm.AlumnosInscripcione = inscripciones;

            inscripcionesForm.ShowDialog();
            this.GetAllAndLoad();
        }
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().IdInscripcion;

            await AlumnosInscripcionesApiClient.DeleteAsync(id);
            this.GetAllAndLoad();
        }
        private AlumnosInscripcione SelectedItem()
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = (int)row.Cells["IdInscripcion"].Value;
            AlumnosInscripcione inscripciones = _inscripciones.First(inscripciones => inscripciones.IdInscripcion == id);
            return inscripciones;
        }
    }
}
