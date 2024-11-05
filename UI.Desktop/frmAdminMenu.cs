﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UI.Desktop.Clients;
using Datos.Models;

namespace UI.Desktop {
    public partial class frmAdminMenu : Form {
        private frmLogin _loginForm;
        private IEnumerable<Plane> _planes;
        private IEnumerable<Especialidade> _especialidades;

        public frmAdminMenu(frmLogin loginForm) {
            _loginForm = loginForm;
            InitializeComponent();
        }

        private void especialidadesButton_Click(object sender, EventArgs e) {
            specialityList specialityList = new specialityList();
            specialityList.ShowDialog();
        }

        private void planesButton_Click(object sender, EventArgs e) {
            plansList plansList = new plansList();
            plansList.ShowDialog();
        }

        private void comisionesButton_Click(object sender, EventArgs e) {
            comissionsList comissionsList = new comissionsList();
            comissionsList.ShowDialog();
        }

        private void cerrarSesionButton_Click(object sender, EventArgs e) {
            ConnectionApiClient.Instance.RemoveBearerToken();
            _loginForm.Show();
            this.Hide();
        }

        private void profesoresBtn_Click(object sender, EventArgs e) {
            personasList profesoresList = new personasList("Profesor");
            profesoresList.ShowDialog();
        }

        private void alumnosBtn_Click(object sender, EventArgs e) {
            personasList alumnosList = new personasList("Alumno");
            alumnosList.ShowDialog();
        }

        private void materiasButton_Click(object sender, EventArgs e) {
            materiasList materiasList = new materiasList();
            materiasList.ShowDialog();
        }

        private void cursosButton_Click(object sender, EventArgs e) {
            cursosList cursosList = new cursosList();
            cursosList.ShowDialog();
        }

        private void frmAdminMenu_Load(object sender, EventArgs e) {
            GetAll();
        }

        private async void GetAll() {
            _planes = await PlanApiClient.GetPlansAsync();
            _especialidades = await SpecialityApiClient.GetSpecialitiesAsync();

            LoadPlanesGraph();
        }

        private void LoadPlanesGraph() {
            planesGraph.Series.Clear();
            planesGraph.Titles.Clear();
            Title title = planesGraph.Titles.Add("Cantidad de alumnos por plan");
            title.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            title.ForeColor = Color.Black;

            ChartArea chartArea = planesGraph.ChartAreas[0];
            chartArea.BackColor = Color.WhiteSmoke;

            chartArea.AxisX.Title = "Planes";
            chartArea.AxisX.LabelStyle.Enabled = false;
            chartArea.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;

            chartArea.AxisY.Title = "Cantidad de alumnos";
            chartArea.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartArea.AxisY.LabelStyle.Interval = 1;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            foreach (var plan in _planes) {
                string especialidad = _especialidades.FirstOrDefault(e => e.IdEspecialidad == plan.IdEspecialidad)?.DescEspecialidad!;
                Series serie = planesGraph.Series.Add($"{especialidad} {plan.DescPlan}");
                serie.ChartType = SeriesChartType.Column;
                serie.Points.Add(plan.CantidadAlumnos!.Value);
                serie["PointWidth"] = "0.6";
                serie.Label = plan.CantidadAlumnos.ToString();
                serie.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            }

            planesGraph.Legends["Legend1"].Font = new Font("Segoe UI", 8, FontStyle.Bold);
            planesGraph.Legends["Legend1"].ForeColor = Color.DarkSlateGray;
        }
    }
}
