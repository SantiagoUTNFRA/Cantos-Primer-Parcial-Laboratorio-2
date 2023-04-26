using FontAwesome.Sharp;

namespace UI_ByteBay
{
    public partial class FrmMain : Form
    {
        private int menuWidth;
        private int iconWidth;
        private bool estaColapsado;
        private Login loginForm;


        public FrmMain()
        {
            InitializeComponent();
            this.loginForm = loginForm;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            menuWidth = flpContenedor.Width;
            iconWidth = pnlInicio.Width;
            estaColapsado = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            flpContenedor.Size = estaColapsado ? new Size(menuWidth, flpContenedor.Height) : new Size(iconWidth, flpContenedor.Height);
            btnMenu.IconChar = estaColapsado ? IconChar.Bars : IconChar.Times;
            btnMenu.Text = estaColapsado ? "" : "Menú";
            estaColapsado = !estaColapsado;
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new()
            {
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                StartPosition = FormStartPosition.Manual,
                ControlBox = false,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false,
                ShowIcon = false,
                MdiParent = this
            };
            frmCategorias.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            App.LoginFormInstance.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            App.LoginFormInstance.Show();
        }
    }

    public static class App
    {
        public static Login LoginFormInstance { get; set; }
    }
}