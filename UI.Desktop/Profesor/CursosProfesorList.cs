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

namespace UI.Desktop.Profesor {
    public partial class CursosProfesorList : Form {
        private readonly frmLogin _loginForm;
        private Persona? _profesor;
        private int _idProfesor = 0;

        public CursosProfesorList(frmLogin loginForm) {
            _loginForm = loginForm;
            InitializeComponent();
        }

        public void SetIDProfesor(int idProfesor) {
            _idProfesor = idProfesor;
        }

        private void cerrarSesionButton_Click(object sender, EventArgs e) {
            ConnectionApiClient.Instance.RemoveBearerToken();
            _loginForm.Show();
            this.Hide();
        }

        private async void CursosProfesorList_Load(object sender, EventArgs e) {
            _profesor = await PersonasApiClient.GetPersonaAsync(_idProfesor, false, true);
            title.Text = $"Bienvenido, {_profesor!.Nombre} {_profesor!.Apellido}";
            List<InfoToShow> info = [];
            foreach (var docenteCurso in _profesor.DocentesCursos) {
                info.Add(new InfoToShow {
                    idCurso = docenteCurso.IdCurso,
                    Año = docenteCurso.IdCursoNavigation!.AnioCalendario.ToString(),
                    Materia = docenteCurso.IdCursoNavigation!.IdMateriaNavigation!.DescMateria,
                    Comision = docenteCurso.IdCursoNavigation!.IdComisionNavigation!.DescComision,
                    Especialidad = docenteCurso.IdCursoNavigation!.IdMateriaNavigation!.IdPlanNavigation!.IdEspecialidadNavigation!.DescEspecialidad,
                    Plan = docenteCurso.IdCursoNavigation!.IdMateriaNavigation!.IdPlanNavigation!.DescPlan
                });
            }
            DataGridView.DataSource = info;
            DataGridView.Columns["idCurso"].Visible = false;
        }

        private void alumnosBtn_Click(object sender, EventArgs e) {
            DataGridViewRow row = DataGridView.SelectedRows[0];
            int idCurso = (int)row.Cells["idCurso"].Value;
            Curso curso = _profesor!.DocentesCursos.First(dc => dc.IdCurso == idCurso).IdCursoNavigation!;
            AlumnosList alumnosList = new AlumnosList(curso);
            alumnosList.ShowDialog();
        }

        private class InfoToShow {
            public int idCurso { get; set; }
            public string Año { get; set; } = null!;
            public string Materia { get; set; } = null!;
            public string Comision { get; set; } = null!;
            public string Especialidad { get; set; } = null!;
            public string Plan { get; set; } = null!;
        }
    }
}
