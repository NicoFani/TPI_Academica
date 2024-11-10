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
using UI.Desktop.Clients;

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

        private async void aceptarBtn_Click(object sender, EventArgs e) {
            string condicion = condicionCombobox.SelectedItem.ToString();

            if (condicion == "Cursando") {
                MessageBox.Show("No se puede asignar la condición 'Cursando' a un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (condicion == "Aprobado" && nota.Text == "") {
                MessageBox.Show("Debe asignar una nota al alumno para la condición 'Aprobado'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (condicion == "Regular" && nota.Text != "") {
                MessageBox.Show("No se puede asignar una nota a un alumno con condición 'Regular'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!int.TryParse(nota.Text, out int notaAlumno) && nota.Text != "") {
                MessageBox.Show("La nota debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if ((notaAlumno < 0 || notaAlumno > 10) && nota.Text != "") {
                MessageBox.Show("La nota debe ser un número entre 0 y 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {

                _inscripcion.Nota = condicion == "Aprobado" ? notaAlumno : null;
                _inscripcion.Condicion = condicion;
                // setting these to null to avoid EF Core from trying to update the related entities
                _inscripcion.IdCursoNavigation = null;
                _inscripcion.IdAlumnoNavigation = null;

                await AlumnosInscripcionesApiClient.UpdateAsync(_inscripcion);
                Close();
            }
        }
    }
}
