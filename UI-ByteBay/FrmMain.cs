using ByteBay.UI_Entidades;

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

        private void intelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intel frmIntel = new Intel();

            frmIntel.MdiParent = this;

            frmIntel.Show();
        }

        private void aMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AMD amd = new AMD();

            amd.MdiParent = this;

            amd.Show();
        }

        private void mostrar()
        {
            
        }
    }
}