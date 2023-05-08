namespace UI_ByteBay
{
    public partial class FrmCategorias : Form
    {
        private GroupBox? groupBoxAbierto = null; // Agrega este campo para almacenar el GroupBox abierto

        public FrmCategorias()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.Manual;
            ShowInTaskbar = false;
            ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }

        private void btnMemorias_MouseEnter(object sender, EventArgs e)
        {
            MostrarGroupBox(btnMemorias, gbxMemorias, 270, -57);
        }

        private void btnGraficas_MouseEnter(object sender, EventArgs e)
        {
            MostrarGroupBox(btnGraficas, gbxGraficas, 270, -57);
        }

        private void btnPerifericos_MouseEnter(object sender, EventArgs e)
        {
            MostrarGroupBox(btnPerifericos, gbxPerifericos, 270, -57);
        }

        private void btnAlmacenamiento_MouseEnter(object sender, EventArgs e)
        {
            MostrarGroupBox(btnAlmacenamiento, gbxDiscos, 270, -57);
        }

        private void btnMother_MouseEnter(object sender, EventArgs e)
        {
            MostrarGroupBox(btnMother, gbxMother, 270, -57);
        }

        private void btnGabinetes_MouseEnter(object sender, EventArgs e)
        {
            MostrarGroupBox(btnGabinetes, gbxGabinetes, 270, -57);
        }

        private void btnProcesadores_MouseEnter(object sender, EventArgs e)
        {
            MostrarGroupBox(btnProcesadores, gbxProcesadores, 270, -57);
        }

        private void MostrarGroupBox(Button button, GroupBox groupBox, int offsetX = 0, int offsetY = 0)
        {
            if (groupBoxAbierto != null && groupBoxAbierto != groupBox)
            {
                groupBoxAbierto.Visible = false;
                groupBoxAbierto.Enabled = false;
            }

            groupBox.Location = new Point(button.Left + offsetX, button.Bottom + offsetY);
            groupBox.Visible = true;
            groupBox.Enabled = true;

            groupBoxAbierto = groupBox; // Guarda el GroupBox abierto en el campo

            tmrTiempoParaSeleccionar.Tag = groupBox;
            tmrTiempoParaSeleccionar.Start();
        }

        private void tmrTiempoParaSeleccionar_Tick(object sender, EventArgs e)
        {
            GroupBox? groupBox = tmrTiempoParaSeleccionar.Tag as GroupBox; // Obtenemos el GroupBox almacenado en el Tag del temporizador

            if (groupBox != null)
            {
                Point cursorPosition = this.PointToClient(Cursor.Position);

                if (!groupBox.Bounds.Contains(cursorPosition))
                {
                    bool isMouseOverButton = false;
                    foreach (Control control in groupBox.Parent.Controls)
                    {
                        if (control is Button button && button.Bounds.Contains(cursorPosition))
                        {
                            isMouseOverButton = true;
                            break;
                        }
                    }

                    if (!isMouseOverButton)
                    {
                        groupBox.Visible = false;
                        groupBox.Enabled = false;
                        tmrTiempoParaSeleccionar.Stop();
                    }
                }
            }
        }
    }
}
