using Datos.Model;
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
        private Comissions comission;
        private ErrorProvider errorProvider = new ErrorProvider();
        //public comissionsForm()
        //{
        //    InitializeComponent();
        //}


        public Comissions Comission
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
                this.Comission.desc_comision = textBox1.Text;

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
            this.textBox1.Text = this.Comission.desc_comision;
            this.textBox2.Text = this.Comission.anio_especialidad.ToString();
            this.textBox3.Text = this.Comission.id_plan.ToString();
            //this.comboBox1.SelectedValue = this.Comission.IdPlan; ((VER))
        }
        // Metodo para cargar los planes en el combobox

        private bool ValidateComission()
        {
            bool isValid = true;

            errorProvider.SetError(textBox1, string.Empty);

            if (this.textBox1.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(textBox1, "La descripción es requerida");
            }
            return isValid;
        }

    }
}
