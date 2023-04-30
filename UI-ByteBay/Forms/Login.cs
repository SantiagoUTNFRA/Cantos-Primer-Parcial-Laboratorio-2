using Logica_de_Negocio;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace UI_ByteBay
{
    public partial class Login : Form
    {

        public static string email;

        public Login()
        {
            InitializeComponent();
        }

        IFirebaseConfig configuracion = new FirebaseConfig()
        {
            AuthSecret = "RDdpXLENiTeOTcnn7CYnFbmqaK04ZSMR13WcpICL",
            BasePath = "https://loginwindowsforms-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient cliente;

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                cliente = new FireSharp.FirebaseClient(configuracion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Chequea tu conexión!");
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            tbcAll.SelectTab(0);
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            tbcAll.SelectTab(1);
        }

        private void btnIniciarSesionInvitado_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            App.LoginFormInstance = this;
            this.Hide();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuarioRegistro.Text) || string.IsNullOrEmpty(txtContraseniaRegistro.Text) || string.IsNullOrEmpty(txtDniRegistro.Text))
            {
                MessageBox.Show("Todos los campos tienen que estar completos para registrarte");
            }
            else
            {
                var registro = new Usuario
                {
                    NombreUsuario = txtUsuarioRegistro.Text,
                    Contrasenia = txtContraseniaRegistro.Text,
                    Email = txtDniRegistro.Text
                };

                FirebaseResponse respuesta = cliente.Set($"usuarios/{txtDniRegistro.Text}", registro);
                Usuario res = respuesta.ResultAs<Usuario>();
                Usuario todo = new Usuario()
                {
                    Email = txtDniRegistro.Text
                };
                var setter = cliente.SetAsync($"Rewards/{txtDniRegistro.Text}", todo);
                MessageBox.Show("Usuario registrado correctamente!");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text))
            {
                MessageBox.Show("Todos los campos tienen que estar completos para iniciar sesión!");
            }
            else
            {
                FirebaseResponse respuesta = cliente.Get("usuarios/");
                Dictionary<string, Usuario> resultado = respuesta.ResultAs<Dictionary<string, Usuario>>();
                if(resultado != null)
                {
                    foreach (var get in resultado)
                    {
                        string nombreUsuarios = get.Value.NombreUsuario;
                        string contraseniaUsuarios = get.Value.Contrasenia;
                        if (txtUsuario.Text == nombreUsuarios)
                        {
                            MessageBox.Show($"Bienvenido{txtUsuario.Text}");
                            nombreUsuarios = txtUsuario.Text;

                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();
                            App.LoginFormInstance = this;
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas!");
                }
            }
        }
    }
}