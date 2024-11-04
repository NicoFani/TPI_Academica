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
    public partial class materiasForm : Form
    {
        private Materia materia;
        private ErrorProvider errorProvider = new ErrorProvider();

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;
                this.SetMateria();
            }
        }
        public bool EditMode { get; set; } = false;
        public materiasForm()
        {
            InitializeComponent();
        }
        private async void acceptButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateMateria())
            {
                this.Materia.DescMateria = textBox1.Text;
                this.Materia.HsSemanales = int.Parse(textBox2.Text);
                this.Materia.HsTotales = int.Parse(textBox3.Text);
                this.Materia.IdPlan = (int)comboBox1.SelectedValue;

                if (this.EditMode)
                {
                    await MateriasApiClient.UpdateAsync(Materia);
                } else
                {
                    await MateriasApiClient.AddAsync(Materia);
                }
                this.Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetMateria()
        {
            this.textBox1.Text = this.Materia.DescMateria;
            this.textBox2.Text = this.Materia.HsSemanales.ToString();
            this.textBox3.Text = this.Materia.HsTotales.ToString();
            this.comboBox1.SelectedValue = this.Materia.IdPlan;
        }
        private bool ValidateMateria()
        {
            bool isValid = true;

            errorProvider.SetError(textBox1, string.Empty);
            errorProvider.SetError(textBox2, string.Empty);
            errorProvider.SetError(textBox3, string.Empty);
            errorProvider.SetError(comboBox1, string.Empty);

            if (this.textBox1.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(textBox1, "La descripción de la materia es requerida");
            }
            if (this.textBox2.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(textBox2, "Las horas semanales son requeridas");
            }
            if (this.textBox3.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(textBox3, "Las horas totales son requeridas");
            }
            if (this.comboBox1.SelectedValue == null)
            {
                isValid = false;
                errorProvider.SetError(comboBox1, "El plan es requerido");
            }
            return isValid;
        }
        private async void LoadPlanes()
        {
            var planes = await PlanApiClient.GetPlansAsync();

            this.comboBox1.DataSource = planes.ToList();
            this.comboBox1.DisplayMember = "DescPlan";
            this.comboBox1.ValueMember = "IdPlan";
        }
        private void materiasForm_Load(object sender, EventArgs e)
        {
            this.LoadPlanes();
        }
    }
}
