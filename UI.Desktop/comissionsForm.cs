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
    public partial class comissionsForm : Form
    {
        private Comisione comission;
        private ErrorProvider errorProvider = new ErrorProvider();

        public Comisione Comission
        {
            get { return comission; }
            set
            {
                comission = value;
                this.SetComission();
            }
        }
        public bool EditMode { get; set; } = false;
        public comissionsForm()
        {
            InitializeComponent();
        }
        private async void acceptButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateComission())
            {
                this.Comission.DescComision = textBox1.Text;
                this.Comission.AnioEspecialidad = int.Parse(textBox2.Text);
                this.Comission.IdPlan = (int)comboBox1.SelectedValue;

                if (this.EditMode)
                {
                    await ComissionApiClient.UpdateAsync(this.Comission);
                }
                else
                {
                    await ComissionApiClient.AddAsync(this.Comission);
                }
                this.Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetComission()
        {
            this.textBox1.Text = this.Comission.DescComision;
            this.textBox2.Text = this.Comission.AnioEspecialidad.ToString();
            this.comboBox1.SelectedValue = this.Comission.IdPlan;
        }

        private bool ValidateComission()
        {
            bool isValid = true;

            errorProvider.SetError(textBox1, string.Empty);
            errorProvider.SetError(textBox2, string.Empty);
            errorProvider.SetError(comboBox1, string.Empty);

            if (this.textBox1.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(textBox1, "La descripción es requerida");
            }
            if (this.textBox2.Text == string.Empty || !int.TryParse(this.textBox2.Text, out _))
            {
                isValid = false;
                errorProvider.SetError(textBox2, "El año de especialidad es requerido y debe ser un número");
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

            SetComission();
        }

        private void comissionsForm_Load(object sender, EventArgs e)
        {
            this.LoadPlanes();
        }
    }

}
