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
    public partial class plansForm : Form
    {
        private Plane plan;
        private ErrorProvider errorProvider = new ErrorProvider();

        public Plane Plan
        {
            get { return plan; }
            set
            {
                plan = value;
                this.SetPlan();
            }
        }
        public bool EditMode { get; set; } = false;

        public plansForm()
        {
            InitializeComponent();
        }
        
        private async void acceptButton_Click(object sender, EventArgs e)
        {
            PlanApiClient client = new PlanApiClient();

            if (this.ValidatePlan())
            {
                this.Plan.DescPlan = this.textBox1.Text;

                if (comboBox1.SelectedValue != null)
                {
                    this.Plan.IdEspecialidad = int.Parse(comboBox1.SelectedValue.ToString());
                }

                if (this.EditMode)
                {
                    await PlanApiClient.UpdateAsync(Plan.IdPlan, this.Plan);
                }
                else
                {
                    await PlanApiClient.AddAsync(this.Plan);
                }

                this.Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetPlan()
        {
            if (this.Plan != null)
            {
                this.textBox1.Text = this.Plan.DescPlan;
                this.comboBox1.SelectedValue = this.Plan.IdEspecialidad;
            }
            else
            {
                // Handle the case where Plan is null
                this.textBox1.Text = string.Empty;
                this.comboBox1.SelectedIndex = -1;
            }
        }

        private bool ValidatePlan()
        {
            bool isValid = true;

            errorProvider.SetError(textBox1, string.Empty);
            errorProvider.SetError(comboBox1, string.Empty);

            if (this.textBox1.Text == string.Empty)
            {
                this.errorProvider.SetError(this.textBox1, "El campo es obligatorio");
                isValid = false;
            }
            if (this.comboBox1.SelectedIndex == -1)
            {
                this.errorProvider.SetError(this.comboBox1, "El campo es obligatorio");
                isValid = false;
            }

            return isValid;
        }
        private async void LoadSpecialities()
        {
            var specialities = await SpecialityApiClient.GetSpecialitiesAsync();
            this.comboBox1.DataSource = specialities.ToList();
            this.comboBox1.DisplayMember = "DescEspecialidad";
            this.comboBox1.ValueMember = "IdEspecialidad";
        }

        private void plansForm_Load(object sender, EventArgs e)
        {
            this.LoadSpecialities();
        }
    }
}
