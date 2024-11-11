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

namespace UI.Desktop {
    public partial class docentesCursosForm : Form {
        private DocentesCurso _docenteCurso;
        private ErrorProvider errorProvider = new ErrorProvider();

        public DocentesCurso DocenteCurso {
            get { return _docenteCurso; }
            set {
                _docenteCurso = value;
                this.SetDocenteCurso();
            }
        }
        public bool EditMode { get; set; } = false;
        public docentesCursosForm() {
            InitializeComponent();
        }
        private async void acceptButton_Click(object sender, EventArgs e) {
            if (this.ValidateDocenteCurso()) {
                this.DocenteCurso.IdCurso = (int)comboBox1.SelectedValue;
                this.DocenteCurso.IdDocente = (int)comboBox2.SelectedValue;
                this.DocenteCurso.Cargo = cargoComboBox.SelectedItem.ToString();
                this.DocenteCurso.IdCursoNavigation = null;
                this.DocenteCurso.IdDocenteNavigation = null;
                if (this.EditMode) {
                    await DocentesCursosApiClient.UpdateAsync(DocenteCurso);
                } else {
                    await DocentesCursosApiClient.AddAsync(DocenteCurso);
                }
            }
            this.Close();
        }
        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SetDocenteCurso() {
            this.comboBox1.SelectedValue = this.DocenteCurso.IdCurso;
            this.comboBox2.SelectedValue = this.DocenteCurso.IdDocente;
            this.cargoComboBox.SelectedItem = this.DocenteCurso.Cargo;
        }

        private bool ValidateDocenteCurso() {
            bool isValid = true;

            errorProvider.SetError(comboBox1, string.Empty);
            errorProvider.SetError(comboBox2, string.Empty);

            if (this.comboBox1.SelectedValue == null) {
                isValid = false;
                errorProvider.SetError(comboBox1, "El curso es requerido");
            }
            if (this.comboBox2.SelectedValue == null) {
                isValid = false;
                errorProvider.SetError(comboBox2, "El docente es requerido");
            }
            return isValid;
        }
        private async void docentesCursosForm_Load(object sender, EventArgs e) {
            string tipoPersona = "Profesor";
            var docentes = await PersonasApiClient.GetPersonasByTipoAsync(tipoPersona);
            var cursos = await CursosApiClient.GetCursosAsync();

            comboBox1.DataSource = cursos.Select(c => new {
                IdCurso = c.IdCurso,
                Curso = $"Esp {c.IdMateriaNavigation!.IdPlanNavigation!.IdEspecialidadNavigation!.DescEspecialidad} Plan {c.IdMateriaNavigation!.IdPlanNavigation!.DescPlan} Com {c.IdComisionNavigation!.DescComision} Mat {c.IdMateriaNavigation!.DescMateria}"
            }).ToList();
            comboBox1.DisplayMember = "Curso";
            comboBox1.ValueMember = "IdCurso";

            comboBox2.DataSource = docentes.Select(d => new {
                IdDocente = d.IdPersona,
                Profesor = $"{d.Apellido}, {d.Nombre}: Leg {d.Legajo}"
            }).ToList();
            comboBox2.DisplayMember = "Profesor";
            comboBox2.ValueMember = "IdDocente";

            if (this.EditMode) {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                SetDocenteCurso();
            } else {
                cargoComboBox.SelectedItem = "Profesor";
            }
        }

    }
}
