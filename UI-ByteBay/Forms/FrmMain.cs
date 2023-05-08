using FontAwesome.Sharp;
using Logica_de_Negocio;
using UI_ByteBay.Forms;

namespace UI_ByteBay
{
    public partial class FrmMain : Form
    {
        private int menuWidth;
        private int iconWidth;
        private bool estaColapsado;

        //Variables para verificar su estado y no volver a abrir el mismo formulario
        private Form formularioActual = null!;

        private readonly FrmInicio frmInicio;
        private readonly FrmCategorias frmCategorias;
        private readonly FrmMiCarrito frmMiCarrito;
        private readonly FrmNosotros frmNosotros;
        private readonly FrmAdministrador frmAdministrador;
        private readonly FrmArmaTuPc frmArmaTuPc;
        private readonly FrmContactanos frmContactanos;

        public FrmMain()
        {
            InitializeComponent();

            frmInicio = new FrmInicio
            {
                MdiParent = this
            };

            frmCategorias = new FrmCategorias
            {
                MdiParent = this
            };

            frmMiCarrito = new FrmMiCarrito
            {
                MdiParent = this
            };

            frmNosotros = new FrmNosotros
            {
                MdiParent = this
            };

            frmAdministrador = new FrmAdministrador
            {
                MdiParent = this
            };

            frmArmaTuPc = new FrmArmaTuPc
            {
                MdiParent = this
            };
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            menuWidth = flpContenedor.Width;
            iconWidth = pnlInicio.Width;
            estaColapsado = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;


            MostrarFormulario(frmInicio);
            UsuarioLogeado usuarioLogeado = UsuarioLogeado.ObtenerInstancia();

            Usuario usuarioActual = usuarioLogeado.GetUsuario();
            if (usuarioActual != null)
            {
                btnUser.Text = "Bienvenido " + usuarioActual.NombreUsuario;
            }
            else
            {
                btnUser.Text = "Modo Invitado";
                btnUser.IconChar = IconChar.UserSecret;
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            flpContenedor.Size = estaColapsado ? new Size(menuWidth, flpContenedor.Height) : new Size(iconWidth, flpContenedor.Height);
            btnMenu.IconChar = estaColapsado ? IconChar.Bars : IconChar.Times;
            btnMenu.Text = estaColapsado ? "" : "Menú";
            estaColapsado = !estaColapsado;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmInicio);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmCategorias);
        }

        private void btnArmarPc_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmArmaTuPc);
        }

        private void btnModoOscuro_Click(object sender, EventArgs e)
        {
            //REALIZAR METODO DE MODO OSCURO
        }

        private void btnMiCarrito_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmMiCarrito);
        }

        private void btnContactanos_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmContactanos);
        }

        private void btnNosotros_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmNosotros);
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            MostrarFormulario(frmAdministrador);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            App.LoginFormInstance.Show();
        }

        #region EVENTOS
        //EVENTOS
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            App.LoginFormInstance.Show();
        }

        #endregion

        #region METODOS
        //METODOS
        private void MostrarFormulario(Form formulario)
        {
            if (formulario == null || formulario == formularioActual) return;

            if (formularioActual != null)
            {
                formularioActual.Hide(); // Oculta el formulario actual
            }

            formulario.MdiParent = this;
            formulario.Show();
            formularioActual = formulario;
        }


        private void OcultarFormularioActual()
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }
        }

        #endregion
    }

    public static class App
    {
        public static Login LoginFormInstance { get; set; }
    }
}
