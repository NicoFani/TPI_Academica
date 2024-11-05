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

namespace UI.Desktop.Profesor {
    public partial class CursosProfesorList : Form {
        private frmLogin _loginForm;

        public CursosProfesorList(frmLogin loginForm) {
            _loginForm = loginForm;
            InitializeComponent();
        }

        private void cerrarSesionButton_Click(object sender, EventArgs e) {
            ConnectionApiClient.Instance.RemoveBearerToken();
            _loginForm.Show();
            this.Hide();
        }
    }
}
