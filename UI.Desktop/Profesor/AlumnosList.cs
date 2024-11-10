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
                Legajo = ai.IdAlumnoNavigation!.Legajo,
                Apellido = ai.IdAlumnoNavigation!.Apellido,
                Nombre = ai.IdAlumnoNavigation!.Nombre,
                Condicion = ai.Condicion,
                Nota = ai.Nota
            }).ToList();
        }
    }
}
