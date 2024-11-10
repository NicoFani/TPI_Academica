using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.Clients;

namespace UI.Desktop {
    public partial class personasList : Form {
        private string _tipoPersona;
        public personasList(string tipoPersona) {
            _tipoPersona = tipoPersona;
            InitializeComponent();
            string title = tipoPersona == "Alumno" ? "Alumnos" : "Profesores";
            this.FindForm().Text = $"Lista de {title}";
        }

        private void addButton_Click(object sender, EventArgs e) {
            new personasForm(_tipoPersona).ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e) {
            int id = (int)DataGridView.SelectedRows[0].Cells["idPersona"].Value;
            new personasForm(_tipoPersona, id).ShowDialog();
            GetAllAndLoad();
        }

        private async void deleteButton_Click(object sender, EventArgs e) {
            int id = (int)DataGridView.SelectedRows[0].Cells["idPersona"].Value;
            await PersonasApiClient.DeleteAsync(id);
            GetAllAndLoad();
        }

        private void personasList_Load(object sender, EventArgs e) {
            GetAllAndLoad();
        }

        private async void GetAllAndLoad() {
            var personas = await PersonasApiClient.GetPersonasByTipoAsync(_tipoPersona);

            var infoShowed = _tipoPersona == "Alumno"
            ? personas.Select(p => new {
                idPersona = p.IdPersona,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Legajo = p.Legajo,
                Direccion = p.Direccion,
                Email = p.Email,
                Telefono = p.Telefono,
                FechaNacimiento = p.FechaNac,
                Usuario = p.NombreUsuario,
                Plan = p.IdPlanNavigation?.DescPlan,
                Especialidad = p.IdPlanNavigation?.IdEspecialidadNavigation?.DescEspecialidad
            }).ToList<object>()
            : personas.Select(p => new {
                idPersona = p.IdPersona,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Legajo = p.Legajo,
                Direccion = p.Direccion,
                Email = p.Email,
                Telefono = p.Telefono,
                FechaNacimiento = p.FechaNac,
                Usuario = p.NombreUsuario
            }).ToList<object>();

            DataGridView.DataSource = infoShowed;
            DataGridView.Columns["idPersona"].Visible = false;
            DataGridView.Columns["FechaNacimiento"].HeaderText = "Fecha de Nacimiento";

            if (DataGridView.Rows.Count > 0) {
                DataGridView.Rows[0].Selected = true;
                deleteButton.Enabled = true;
                updateButton.Enabled = true;
            } else {
                deleteButton.Enabled = false;
                updateButton.Enabled = false;
            }
        }
    }
}
