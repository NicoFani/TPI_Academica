using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using UI.Desktop.Clients;
using Datos.Models;

namespace UI.Desktop {
    public partial class InscripcionesForm : Form {
        private AlumnosInscripcione inscripciones;
        private ErrorProvider errorProvider = new ErrorProvider();

        public AlumnosInscripcione AlumnosInscripcione {
            get { return inscripciones; }
            set {
                inscripciones = value;
                this.SetInscripcion();
            }
        }
        public bool EditMode { get; set; } = false;

        public InscripcionesForm() {
            InitializeComponent();
        }
        private async void acceptButton_Click(object sender, EventArgs e) {
            this.AlumnosInscripcione.IdAlumno = (int)comboBox1.SelectedValue;
            this.AlumnosInscripcione.IdCurso = (int)comboBox2.SelectedValue;

            this.AlumnosInscripcione.IdCursoNavigation = null;
            this.AlumnosInscripcione.IdAlumnoNavigation = null;
            this.AlumnosInscripcione.Nota = null;

            if (this.EditMode) {
                if (this.ValidateAlumnosInscripcione()) {
                    this.AlumnosInscripcione.Condicion = condicionCombobox.SelectedItem.ToString();

                    if (this.AlumnosInscripcione.Condicion == "Aprobado") {
                        this.AlumnosInscripcione.Nota = int.Parse(nota.Text);
                    }

                    await AlumnosInscripcionesApiClient.UpdateAsync(AlumnosInscripcione);
                    this.Close();
                }
            } else {
                this.AlumnosInscripcione.Condicion = "Cursando";
                await AlumnosInscripcionesApiClient.AddAsync(AlumnosInscripcione);
                this.Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SetInscripcion() {
            this.comboBox1.SelectedValue = this.AlumnosInscripcione.IdAlumno;
            this.comboBox2.SelectedValue = this.AlumnosInscripcione.IdCurso;
            this.condicionCombobox.SelectedItem = this.AlumnosInscripcione.Condicion;
            this.nota.Text = this.AlumnosInscripcione.Nota.ToString();
        }
        private bool ValidateAlumnosInscripcione() {
            bool isValid = false;
            string condicion = condicionCombobox.SelectedItem.ToString();
            if (condicion == "Cursando") {
                MessageBox.Show("No se puede asignar la condición 'Cursando' a un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (condicion == "Aprobado" && nota.Text == "") {
                MessageBox.Show("Debe asignar una nota al alumno para la condición 'Aprobado'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (condicion == "Regular" && nota.Text != "") {
                MessageBox.Show("No se puede asignar una nota a un alumno con condición 'Regular'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!int.TryParse(nota.Text, out int notaAlumno) && nota.Text != "") {
                MessageBox.Show("La nota debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if ((notaAlumno < 0 || notaAlumno > 10) && nota.Text != "") {
                MessageBox.Show("La nota debe ser un número entre 0 y 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                isValid = true;
            }
            return isValid;
        }
        private async void inscripcionesForm_Load(object sender, EventArgs e) {
            string tipoPersona = "Alumno";
            var alumnos = await PersonasApiClient.GetPersonasByTipoAsync(tipoPersona);
            var cursos = await CursosApiClient.GetCursosAsync();

            comboBox1.DataSource = alumnos.Select(a => new {
                IdAlumno = a.IdPersona,
                Alumno = $"{a.Apellido}, {a.Nombre}: Leg {a.Legajo}"
            }).ToList();
            comboBox1.DisplayMember = "Alumno";
            comboBox1.ValueMember = "IdAlumno";

            comboBox2.DataSource = cursos.Select(c => new {
                IdCurso = c.IdCurso,
                Curso = $"Esp {c.IdMateriaNavigation!.IdPlanNavigation!.IdEspecialidadNavigation!.DescEspecialidad} Plan {c.IdMateriaNavigation!.IdPlanNavigation!.DescPlan} Com {c.IdComisionNavigation!.DescComision} Mat {c.IdMateriaNavigation!.DescMateria}"
            }).ToList();
            comboBox2.DisplayMember = "Curso";
            comboBox2.ValueMember = "IdCurso";

            if (this.EditMode) {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                SetInscripcion();

                if (AlumnosInscripcione.Condicion != "Aprobado") {
                    condicionCombobox.Enabled = true;
                    nota.Enabled = true;
                    aceptarBtn.Enabled = true;
                } else if (AlumnosInscripcione.Condicion == "Regular") {
                    condicionCombobox.Items.Remove("Cursando");
                }
            } else {
                condicionCombobox.SelectedItem = "Cursando";
                aceptarBtn.Enabled = true;
            }
        }
    }
}
