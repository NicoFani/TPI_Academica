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
        private IEnumerable<Plane> _planes;
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
            _planes = await PlanApiClient.GetPlansAsync();

            dataGridView1.DataSource = _planes.Select(p => new {
                idPlan = p.IdPlan,
                Plan = p.DescPlan,
                Especialidad = p.IdEspecialidadNavigation?.DescEspecialidad,
                CantidadAlumnos = p.CantidadAlumnos
            }).ToList();
            dataGridView1.Columns["idPlan"].Visible = false;
            dataGridView1.Columns["CantidadAlumnos"].HeaderText = "Cantidad de Alumnos";

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
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = (int)row.Cells["IdPlan"].Value;
            Plane plan = _planes.First(p => p.IdPlan == id);
            return plan;
        }
    }
}
