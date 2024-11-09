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
    public partial class AsignacionNotasAlumno : Form {
        private readonly Curso _curso;
        private readonly AlumnosInscripcione _inscripcion;
        public AsignacionNotasAlumno(Curso curso, AlumnosInscripcione inscripcion) {
            _curso = curso;
            _inscripcion = inscripcion;
            InitializeComponent();
        }

        private void AsignacionNotasAlumno_Load(object sender, EventArgs e) {
            title.Text = $"{_curso.IdMateriaNavigation!.DescMateria} - Año: {_curso.AnioCalendario} - Comision: {_curso.IdComisionNavigation!.DescComision} - {_curso.IdMateriaNavigation!.IdPlanNavigation!.IdEspecialidadNavigation!.DescEspecialidad} - Plan: {_curso.IdMateriaNavigation!.IdPlanNavigation!.DescPlan}";
            alumnoInfo.Text = $"{_inscripcion.IdAlumnoNavigation!.Apellido}, {_inscripcion.IdAlumnoNavigation!.Nombre} - Legajo: {_inscripcion.IdAlumnoNavigation!.Legajo}";

            if (_inscripcion.Nota.HasValue) {
                nota.Text = _inscripcion.Nota.ToString();
            }
            // not checking for null because default value is set to "Cursando"
            condicionCombobox.SelectedItem = _inscripcion.Condicion;
            if (_inscripcion.Condicion != "Aprobado") {
                nota.Enabled = true;
                condicionCombobox.Enabled = true;
                aceptarBtn.Enabled = true;
            }
            if (_inscripcion.Condicion == "Regular") {
                condicionCombobox.Items.Remove("Cursando");
            }
        }

        private void aceptarBtn_Click(object sender, EventArgs e) {
            if (int.TryParse(nota.Text, out int notaAlumno)) {
                _inscripcion.Nota = notaAlumno;
                _inscripcion.Condicion = condicionCombobox.SelectedItem.ToString();
            } else {
                MessageBox.Show("La nota debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
