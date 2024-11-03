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
    public partial class specialityForm : Form
    {
        private Especialidade speciality;
        private ErrorProvider errorProvider = new ErrorProvider();

        public Especialidade Speciality
        {
            get { return speciality; }
            set
            {
                speciality = value;
                this.SetSpeciality();
            }
        }
        public bool EditMode { get; set; }

        public specialityForm()
        {
            InitializeComponent();
        }
        private async void acceptButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateSpeciality())
            {
                if (this.Speciality == null)
                {
                    this.Speciality = new Especialidade();
                }

                this.Speciality.DescEspecialidad = this.descTextBox.Text;
                if (this.EditMode)
                {
                    await SpecialityApiClient.UpdateAsync(Speciality.IdEspecialidad, Speciality);
                }
                else
                {
                    await SpecialityApiClient.AddAsync(this.Speciality);
                }
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetSpeciality()
        {
            if (this.Speciality != null)
            {
                this.descTextBox.Text = this.Speciality.DescEspecialidad;
            }
            else
            {
                // Manejar el caso donde Speciality es null
                this.descTextBox.Text = string.Empty;
            }
        }

        private bool ValidateSpeciality()
        {
            bool isValid = true;
            errorProvider.SetError(descTextBox, string.Empty);
            if (this.descTextBox.Text == string.Empty)
            {
                errorProvider.SetError(descTextBox, "La descripción es requerida");
                isValid = false;
            }
            return isValid;
        }
    }
}
