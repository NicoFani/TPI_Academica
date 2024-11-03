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
    public partial class plansList : Form
    {
        public plansList()
        {
            InitializeComponent();
        }
        private void plans_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
        private async void GetAllAndLoad()
        {
            var plans = await PlanApiClient.GetPlansAsync();

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = plans.ToList();

            if (this.dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.Rows[0].Selected = true;
                this.deleteButton.Enabled = true;
                this.updateButton.Enabled = true;
            }
            else
            {
                this.deleteButton.Enabled = false;
                this.updateButton.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            plansForm planForm = new plansForm();
            Plane newPlan = new Plane();
            planForm.Plan = newPlan;
            planForm.ShowDialog();
            this.GetAllAndLoad();
        }
        private async void updateButton_Click(object sender, EventArgs e)
        {
            plansForm planForm = new plansForm();
            int id;
            id = this.SelectedItem().IdPlan;

            Plane plan = await PlanApiClient.GetPlanAsync(id);

            if (plan == null)
            {
                MessageBox.Show("No se pudo obtener el plan");
            }

            planForm.EditMode = true;
            planForm.Plan = plan;
            planForm.ShowDialog();
            this.GetAllAndLoad();
            var selectedPlan = SelectedItem();

        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int id;
            id = this.SelectedItem().IdPlan;

            await PlanApiClient.DeleteAsync(id);
            this.GetAllAndLoad();
        }
        private Plane SelectedItem()
        {
            Plane plan;

            plan = (Plane)dataGridView1.SelectedRows[0].DataBoundItem;

            return plan;
        }



    }
}
