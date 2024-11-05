using UI.Desktop.Clients;
using UI.Desktop.Profesor;

namespace UI.Desktop {
    public partial class frmLogin : Form {
        private frmAdminMenu _adminMenu;
        private CursosProfesorList _profesor;
        public frmLogin() {
            InitializeComponent();
            _adminMenu = new frmAdminMenu(this);
            _adminMenu.FormClosed += (s, args) => this.Close();
            _profesor = new CursosProfesorList(this);
            _profesor.FormClosed += (s, args) => this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void fontDialog1_Apply(object sender, EventArgs e) {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void frmMain_Load(object sender, EventArgs e) {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e) {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {

        }

        private async void signInBtn_Click(object sender, EventArgs e) {
            string username = usuarioInput.Text;
            string password = claveInput.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("Debe completar todos los campos");
                return;
            } else {
                var result = await PersonasApiClient.SignIn(username, password);
                if (result["valid"] == "true" && result["TipoPersona"] == "Admin") {
                    _adminMenu.Show();
                    this.Hide();
                } else if (result["valid"] == "true" && result["TipoPersona"] == "Profesor") {
                    _profesor.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("Usuario o contraseña inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                signInBtn_Click(sender, e);
            }
        }
    }
}
