namespace UI_ByteBay
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.Manual;
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            ShowIcon = false;
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            // Agregar elementos al control ListView
            ListViewItem item = new ListViewItem("Procesadores");
            item.SubItems.Add("Intel");
            item.SubItems.Add("$300");
            item.SubItems.Add("5");
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("estoy encima");
        }
    }
}
