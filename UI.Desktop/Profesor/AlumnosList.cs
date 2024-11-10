using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Models;
using UI.Desktop.Clients;

namespace UI.Desktop.Profesor {
    public partial class AlumnosList : Form {
        private readonly Curso _curso;
        public AlumnosList(Curso curso) {
            _curso = curso;
            InitializeComponent();
        }

        private void AlumnosList_Load(object sender, EventArgs e) {
            title.Text = $"{_curso.IdMateriaNavigation!.DescMateria} - Año: {_curso.AnioCalendario} - Comision: {_curso.IdComisionNavigation!.DescComision} - {_curso.IdMateriaNavigation!.IdPlanNavigation!.IdEspecialidadNavigation!.DescEspecialidad} - Plan: {_curso.IdMateriaNavigation!.IdPlanNavigation!.DescPlan}";
            DataGridView.DataSource = _curso.AlumnosInscripciones.Select(ai => new {
                idInscripcion = ai.IdInscripcion,
                Legajo = ai.IdAlumnoNavigation?.Legajo,
                Apellido = ai.IdAlumnoNavigation?.Apellido,
                Nombre = ai.IdAlumnoNavigation?.Nombre,
                Condicion = ai.Condicion,
                Nota = ai.Nota
            }).ToList();
            DataGridView.Columns["idInscripcion"].Visible = false;
        }

        // ...

        private async void alumnoBtn_Click(object sender, EventArgs e) {
            DataGridViewRow row = DataGridView.SelectedRows[0];
            int idInscripcion = (int)row.Cells["idInscripcion"].Value;
            AlumnosInscripcione inscripcion = _curso.AlumnosInscripciones.First(al => al.IdInscripcion == idInscripcion);
            AsignacionNotasAlumno notaForm = new AsignacionNotasAlumno(_curso, inscripcion);
            notaForm.ShowDialog();
            var inscripciones = await AlumnosInscripcionesApiClient.GetAlumnosInscripcionesByCursoAsync(_curso.IdCurso);
            _curso.AlumnosInscripciones = new Collection<AlumnosInscripcione>(inscripciones.ToList());
            AlumnosList_Load(sender, e);
        }
    }
}
