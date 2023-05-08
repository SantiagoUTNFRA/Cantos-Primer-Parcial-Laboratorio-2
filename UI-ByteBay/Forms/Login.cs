using Firestore;
using Logica_de_Negocio;

namespace UI_ByteBay
{
    public partial class Login : Form
    {
        private readonly GestorUsuario _gestorUsuario;

        public Login()
        {
            InitializeComponent();

            _gestorUsuario = new GestorUsuario();
        }

        private void btnIniciarSesionInvitado_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private async void btnRegistro_Click(object sender, EventArgs e)
        {
            ResultadoOp resultado = await _gestorUsuario.CrearUsuarioAsync(txtUsuarioRegistro.Text, txtContraseniaRegistro.Text);

            if (resultado.EsExitoso)
            {
                MessageBox.Show($"Cuenta creada con exito");
            }
            else
            {
                MessageBox.Show($"Error al crear el usuario");
            }
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            ResultadoOp resultado = await _gestorUsuario.EsCredencialValidaAsync(txtUsuario.Text, txtContrasenia.Text);

            if (resultado.EsExitoso)
            {
                UsuarioLogeado usuarioLogeado = UsuarioLogeado.ObtenerInstancia();
                Usuario usuario = new() { NombreUsuario = txtUsuario.Text, Contrasenia = txtContrasenia.Text };
                usuarioLogeado.SetUsuario(usuario);

                Iniciar();
            }
            else
            {
                MessageBox.Show($"Error al iniciar sesión: {resultado.Datos}");
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

        private void Iniciar()
        {
            FrmMain frmMain = new();
            frmMain.Show();
            App.LoginFormInstance = this;
            this.Hide();
        }

    }
}