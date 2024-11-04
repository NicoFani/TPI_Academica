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

namespace UI.Desktop {
    public partial class frmAdminMenu : Form {
        private frmLogin _loginForm;
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
    }
}
