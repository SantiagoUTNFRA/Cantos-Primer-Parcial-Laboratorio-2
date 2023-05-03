using Firestore;
using Google.Cloud.Firestore;
using Logica_de_Negocio;

namespace UI_ByteBay
{
    public partial class Login : Form
    {
        private readonly GestorFirestore _gestorFirestore;

        public Login()
        {
            InitializeComponent();

            _gestorFirestore = new GestorFirestore();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnIniciarSesionInvitado_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            App.LoginFormInstance = this;
            this.Hide();
        }

        private async void btnRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuarioRegistro.Text;
            int contrasenia = int.Parse(txtContraseniaRegistro.Text);

            ResultadoOp resultado = await _gestorFirestore.CrearUsuarioAsync(nombre, contrasenia);

            if (resultado.EsExitoso)
            {
                MessageBox.Show($"Usuario creado con éxito. ID: {resultado.Datos}");
            }
            else
            {
                MessageBox.Show($"Error al crear el usuario: {resultado.Datos}");
            }
        }
        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuarioID = txtUsuario.Text;

            ResultadoOp resultado = await _gestorFirestore.ObtenerUsuarioAsync(usuarioID);

            if (resultado.EsExitoso)
            {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                App.LoginFormInstance = this;
                this.Hide();
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


        /*private async void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasenia = txtContrasenia.Text;

            var resultado = await _gestorFirestore.ObtenerUsuarioAsync(usuario);

            if (resultado.EsExitoso)
            {
                var usuarioData = resultado.Datos as Dictionary<string, object>;

                if (usuarioData != null && usuarioData.TryGetValue("Contrasenia", out object storedContrasenia))
                {
                    if (contrasenia == storedContrasenia.ToString())
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                        // Procede con la lógica de inicio de sesión, por ejemplo, mostrar el formulario principal
                        FrmMain frmMain = new FrmMain();
                        frmMain.Show();
                        App.LoginFormInstance = this;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }
                }
                else
                {
                    MessageBox.Show("Error al iniciar sesión: no se pudo obtener la contraseña del usuario.");
                }
            }
            else
            {
                MessageBox.Show($"Error al iniciar sesión: {resultado.Datos}");
            }
        }*/

    }
}