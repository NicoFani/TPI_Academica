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
    public partial class personasForm : Form {
        private int _idPersona = 0;
        private string _tipoPersona;
        private Persona _persona = new Persona();
        private IEnumerable<Plane> _planes;
        public personasForm(string tipo) {
            _tipoPersona = tipo;
            InitializeComponent();
        }

        public personasForm(string tipo, int idPersona) {
            InitializeComponent();
            _tipoPersona = tipo;
            _idPersona = idPersona;
        }

        private async void personasForm_Load(object sender, EventArgs e) {
            _planes = await PlanApiClient.GetPlansAsync();
            planInput.DataSource = _planes;
            planInput.DisplayMember = "DescPlan";
            planInput.ValueMember = "IdPlan";
            if (_idPersona != 0) {
                _persona = await PersonasApiClient.GetPersonaAsync(_idPersona);
                nombreInput.Text = _persona.Nombre;
                apellidoInput.Text = _persona.Apellido;
                direccionInput.Text = _persona.Direccion;
                emailInput.Text = _persona.Email;
                telefonoInput.Text = _persona.Telefono;
                nacimientoInput.Value = _persona.FechaNac;
                legajoInput.Text = _persona.Legajo.ToString();
                planInput.SelectedValue = _persona.IdPlan;
                userInput.Text = _persona.NombreUsuario;
                contraseñaInput.Text = _persona.Clave;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (_idPersona == 0) {
                _persona = new Persona();
                setValues();
                PersonasApiClient.AddAsync(_persona);
            } else {
                setValues();
                PersonasApiClient.UpdateAsync(_idPersona, _persona);
            }
            this.Close();
        }

        private void setValues() {
            _persona.Nombre = nombreInput.Text;
            _persona.Apellido = apellidoInput.Text;
            _persona.Direccion = direccionInput.Text;
            _persona.Email = emailInput.Text;
            _persona.Telefono = telefonoInput.Text;
            _persona.FechaNac = nacimientoInput.Value;
            _persona.Legajo = int.Parse(legajoInput.Text);
            _persona.IdPlan = (int)planInput.SelectedValue;
            _persona.NombreUsuario = userInput.Text;
            _persona.Clave = contraseñaInput.Text;
            _persona.TipoPersona = _tipoPersona;
        }

        private void personasForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                button1_Click(sender, e);
            }
        }
    }
}
