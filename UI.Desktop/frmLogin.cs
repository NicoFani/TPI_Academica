using UI.Desktop.Clients;
namespace UI.Desktop {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
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

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e) {
            frmRegister formRegistro = new frmRegister();
            frmLogin formLogin = new frmLogin();
            formLogin.Close();
            formRegistro.Show();
        }

        private async void signInBtn_Click(object sender, EventArgs e) {
            string username = usuarioInput.Text;
            string password = claveInput.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("Debe completar todos los campos");
                return;
            } else {
                bool success = await PersonasApiClient.SignIn(username, password);
                if (success) {
                    frmMain formMain = new frmMain();
                    formMain.FormClosed += (s, args) => this.Close();
                    formMain.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("Asegurese de haber introducido bien su nombre de usuario y contraseña, además debe ser administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
