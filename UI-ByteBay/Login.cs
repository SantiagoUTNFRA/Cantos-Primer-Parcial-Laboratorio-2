using Logica_de_Negocio;

namespace UI_ByteBay
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ControladorLogin controlLogin = new ControladorLogin();

            if (controlLogin.IniciarSesion(txtUsuario.Text, txtContrasenia.Text))
            {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                App.LoginFormInstance = this;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error de inicio de sesión");
            }
        }
    }
}
