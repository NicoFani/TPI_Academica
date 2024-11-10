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

namespace UI.Desktop
{
    public partial class InscripcionesForm : Form
    {
        private AlumnosInscripcione inscripciones;
        private ErrorProvider errorProvider = new ErrorProvider();

        public AlumnosInscripcione AlumnosInscripcione
        {
            get { return inscripciones; }
            set
            {
                inscripciones = value;
                this.SetInscripcion();
            }
        }
        public bool EditMode { get; set; } = false;

        public InscripcionesForm()
        {
            InitializeComponent();
        }
        private async void acceptButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateAlumnosInscripcione())
            {
                this.AlumnosInscripcione.IdAlumno = (int)comboBox1.SelectedValue;
                this.AlumnosInscripcione.IdCurso = (int)comboBox2.SelectedValue;
                this.AlumnosInscripcione.Condicion = textBox1.Text;
                this.AlumnosInscripcione.IdCursoNavigation = null;
                this.AlumnosInscripcione.IdAlumnoNavigation = null;

                if (this.EditMode)
                {
                    await AlumnosInscripcionesApiClient.UpdateAsync(AlumnosInscripcione);
                }
                else
                {
                    await AlumnosInscripcionesApiClient.AddAsync(AlumnosInscripcione);
                }
            }
            this.Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetInscripcion()
        {
            this.comboBox1.SelectedValue = this.AlumnosInscripcione.IdAlumno;
            this.comboBox2.SelectedValue = this.AlumnosInscripcione.IdCurso;
            this.textBox1.Text = this.AlumnosInscripcione.Condicion;
       
        }
        private bool ValidateAlumnosInscripcione()
        {
            bool isValid = true;

            errorProvider.SetError(comboBox1, string.Empty);
            errorProvider.SetError(comboBox2, string.Empty);
            errorProvider.SetError(textBox1, string.Empty);

            if (this.comboBox1.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(comboBox1, "El alumno es requerido");
            }
            if (this.comboBox2.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(comboBox2, "El curso es requerido");
            }
            if (this.textBox1.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(textBox1, "La condición es requerida");
            }
            return isValid;
        }
        private async void inscripcionesForm_Load(object sender, EventArgs e)
        {
            string tipoPersona = "Alumno";
            var alumnos = await PersonasApiClient.GetPersonasByTipoAsync(tipoPersona);
            var cursos = await CursosApiClient.GetCursosAsync();

            comboBox1.DataSource = alumnos.ToList();
            comboBox1.DisplayMember = "Apellido";
            comboBox1.ValueMember = "IdPersona";

            comboBox2.DataSource = cursos.ToList();
            comboBox2.DisplayMember = "IdCurso";
            comboBox2.ValueMember = "IdCurso";

            if (this.EditMode)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox1.SelectedValue = this.AlumnosInscripcione.IdAlumno;
                comboBox2.SelectedValue = this.AlumnosInscripcione.IdCurso;
            }
        }

    }
}
