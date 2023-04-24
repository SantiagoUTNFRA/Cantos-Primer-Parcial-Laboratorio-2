using UI_ByteBay.UI_Entidades;
using UI_ByteBay.UI_Entidades.Almacenamiento;
using UI_ByteBay.UI_Entidades.Memorias_RAM;
using UI_ByteBay.UI_Entidades.Procesadores;
using UI_ByteBay.UI_Entidades.Tarjetas_gráficas;

namespace UI_ByteBay
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void MostrarFormulario(FrmGenerico formulario)
        {
            var formularioEspecifico = formulario.CrearFormularioEspecifico();
            formularioEspecifico.MdiParent = this;
            formularioEspecifico.Show();
        }

        #region Mostrar Formularios
        // Procesadores
        private void tsr_intel_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmIntel());
        }

        private void tsr_amdProcesador_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmAMD());
        }

        // Tarjetas gráficas
        private void tsr_nvidia_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmNvidia());
        }

        private void tsr_amdGrafica_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmAMDGrafica());
        }

        // Memorias
        private void tsr_ddr4_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmDdr4());

        }

        private void tsr_ddr5_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmDdr5());
        }

        // Almacenamiento
        private void tsr_ssd_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmSsd());
        }

        private void tsr_hdd_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmHdd());
        }

        // Mother

        // Perifericos
        private void tsr_teclados_Click(object sender, EventArgs e)
        {

        }

        private void tsr_auriculares_Click(object sender, EventArgs e)
        {

        }

        private void tsr_mouse_Click(object sender, EventArgs e)
        {

        }

        private void tsr_parlantes_Click(object sender, EventArgs e)
        {

        }

        private void tsr_microfonos_Click(object sender, EventArgs e)
        {

        }

        private void tsr_sillas_Click(object sender, EventArgs e)
        {

        }

        private void tsr_camaras_Click(object sender, EventArgs e)
        {

        }

        private void tsr_monitores_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new FrmIntel());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}