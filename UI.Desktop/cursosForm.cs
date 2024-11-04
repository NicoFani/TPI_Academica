using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Models;
using UI.Desktop.Clients;

namespace UI.Desktop
{
    public partial class cursosForm : Form
    {
        private Curso curso;
        private ErrorProvider errorProvider = new ErrorProvider();

        public Curso Curso
        {
            get { return curso; }
            set
            {
                curso = value;
                this.SetCurso();
            }
        }
        public bool EditMode { get; set; } = false;
        public cursosForm()
        {
            InitializeComponent();
        }
        private async void acceptButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateCurso())
            {
                this.Curso.AnioCalendario = int.Parse(textBox1.Text);
                this.Curso.Cupo = int.Parse(textBox2.Text);
                this.Curso.IdComision = (int)comboBox1.SelectedValue;
                this.Curso.IdMateria = (int)comboBox2.SelectedValue;

                if (this.EditMode)
                {
                    await CursosApiClient.UpdateAsync(Curso);
                }
                else
                {
                    await CursosApiClient.AddAsync(Curso);
                }
            }
            this.Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetCurso()
        {
            this.textBox1.Text = this.Curso.AnioCalendario.ToString();
            this.textBox2.Text = this.Curso.Cupo.ToString();
            this.comboBox1.SelectedValue = this.Curso.IdComision;
            this.comboBox2.SelectedValue = this.Curso.IdMateria;
        }
        private bool ValidateCurso()
        {
            bool isValid = true;

            errorProvider.SetError(textBox1, string.Empty);
            errorProvider.SetError(textBox2, string.Empty);
            errorProvider.SetError(comboBox1, string.Empty);
            errorProvider.SetError(comboBox2, string.Empty);

            if (this.textBox1.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(textBox1, "El año calendario es requerido");
            }
            if (this.textBox2.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(textBox2, "El cupo es requerido");
            }
            if (this.comboBox1.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(comboBox1, "La comisión es requerida");
            }
            if (this.comboBox2.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(comboBox2, "La materia es requerida");
            }
            return isValid;
        }
        private async void cursosForm_Load(object sender, EventArgs e)
        {
            var comisiones = await ComissionApiClient.GetComissionsAsync();
            var materias = await MateriasApiClient.GetMateriasAsync();

            comboBox1.DataSource = comisiones.ToList();
            comboBox1.DisplayMember = "DescComision";
            comboBox1.ValueMember = "IdComision";

            comboBox2.DataSource = materias.ToList();
            comboBox2.DisplayMember = "DescMateria";
            comboBox2.ValueMember = "IdMateria";

            if (this.EditMode)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox1.SelectedValue = this.Curso.IdComision;
                comboBox2.SelectedValue = this.Curso.IdMateria;
            }
        }

    }
}
