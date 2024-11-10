using System;
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
    public partial class frmAdminMenu : Form
    {
        private frmLogin _loginForm;
        private IEnumerable<Plane> _planes = [];
        private IEnumerable<Especialidade> _especialidades = [];
        private IEnumerable<Materia> _materias = [];

        public frmAdminMenu(frmLogin loginForm)
        {
            _loginForm = loginForm;
            InitializeComponent();
        }

        private void especialidadesButton_Click(object sender, EventArgs e)
        {
            specialityList specialityList = new specialityList();
            specialityList.ShowDialog();
        }

        private void planesButton_Click(object sender, EventArgs e)
        {
            plansList plansList = new plansList();
            plansList.ShowDialog();
        }

        private void comisionesButton_Click(object sender, EventArgs e)
        {
            comissionsList comissionsList = new comissionsList();
            comissionsList.ShowDialog();
        }

        private void cerrarSesionButton_Click(object sender, EventArgs e)
        {
            ConnectionApiClient.Instance.RemoveBearerToken();
            _loginForm.Show();
            this.Hide();
        }

        private void profesoresBtn_Click(object sender, EventArgs e)
        {
            personasList profesoresList = new personasList("Profesor");
            profesoresList.ShowDialog();
        }

        private void alumnosBtn_Click(object sender, EventArgs e)
        {
            personasList alumnosList = new personasList("Alumno");
            alumnosList.ShowDialog();
        }

        private void materiasButton_Click(object sender, EventArgs e)
        {
            materiasList materiasList = new materiasList();
            materiasList.ShowDialog();
        }

        private void cursosButton_Click(object sender, EventArgs e)
        {
            cursosForm cursosList = new cursosForm();
            cursosList.ShowDialog();
        }

        private void inscripcionesButton_Click(object sender, EventArgs e)
        {
            InscripcionesList inscripcionesList = new InscripcionesList();
            inscripcionesList.ShowDialog();
        }

        private void docentesCursosButton_Click(object sender, EventArgs e)
        {
            docentesCursosList docentesCursosList = new docentesCursosList();
            docentesCursosList.ShowDialog();
        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private async void GetAll()
        {
            _planes = await PlanApiClient.GetPlansAsync();
            _especialidades = await SpecialityApiClient.GetSpecialitiesAsync();
            _materias = await MateriasApiClient.GetMateriasByYearAsync("2022");
            yearInput.Text = "2022";
            LoadPlanesGraph();
            LoadMateriasGraph();
        }

        private void SetGraphProperties(Chart chart, string titleGeneral, string titleX, string titleY)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            Title title = chart.Titles.Add(titleGeneral);
            title.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            title.ForeColor = Color.Black;

            chart.Legends["Legend1"].Font = new Font("Segoe UI", 8, FontStyle.Bold);
            chart.Legends["Legend1"].ForeColor = Color.DarkSlateGray;

            ChartArea chartArea = chart.ChartAreas[0];
            chartArea.BackColor = Color.WhiteSmoke;

            chartArea.AxisX.Title = titleX;
            chartArea.AxisX.LabelStyle.Enabled = false;
            chartArea.AxisX.TitleFont = new Font("Segoe UI", 8, FontStyle.Bold);
            chartArea.AxisX.MajorGrid.LineColor = Color.DarkSlateGray;

            chartArea.AxisY.Title = titleY;
            chartArea.AxisY.TitleFont = new Font("Segoe UI", 8, FontStyle.Bold);
            chartArea.AxisY.LabelStyle.Interval = 1;
            chartArea.AxisY.MajorGrid.LineColor = Color.DarkSlateGray;
        }

        private void LoadPlanesGraph()
        {
            SetGraphProperties(planesGraph, "Cantidad de alumnos por plan", "Planes", "Cantidad de alumnos");

            foreach (var plan in _planes)
            {
                string especialidad = _especialidades.FirstOrDefault(e => e.IdEspecialidad == plan.IdEspecialidad)?.DescEspecialidad!;
                Series serie = planesGraph.Series.Add($"{especialidad} {plan.DescPlan}");
                serie.ChartType = SeriesChartType.Column;
                serie.Points.Add(plan.CantidadAlumnos!.Value);
                serie["PointWidth"] = "0.6";
                serie.Label = plan.CantidadAlumnos.ToString();
                serie.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            }
        }
        private void LoadMateriasGraph()
        {
            SetGraphProperties(materiasGraph, "Cantidad de alumnos por materia en un determinado año", "Materias", "Cantidad de alumnos");

            foreach (var materia in _materias)
            {
                Plane plan = _planes.FirstOrDefault(p => p.IdPlan == materia.IdPlan)!;
                string descEspecialidad = _especialidades.FirstOrDefault(e => e.IdEspecialidad == plan.IdEspecialidad)!.DescEspecialidad!;

                Series serie = materiasGraph.Series.Add($"{materia.DescMateria} - {descEspecialidad} {plan.DescPlan}");
                serie.ChartType = SeriesChartType.Column;
                serie.Points.Add(materia.CantidadAlumnos!.Value);
                serie["PointWidth"] = "0.6";
                serie.Label = materia.CantidadAlumnos.ToString();
                serie.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            }
        }

        private async void LoadMaterias()
        {
            string year = yearInput.Text;
            _materias = await MateriasApiClient.GetMateriasByYearAsync(year);
            LoadMateriasGraph();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadMaterias();
        }
    }
}
