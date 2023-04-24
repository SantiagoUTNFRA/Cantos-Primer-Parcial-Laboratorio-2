namespace UI_ByteBay
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            tsr_busqueda = new ToolStripMenuItem();
            tsc_procesadores = new ToolStripMenuItem();
            tsr_intel = new ToolStripMenuItem();
            tsr_amdProcesador = new ToolStripMenuItem();
            tsc_graficas = new ToolStripMenuItem();
            tsr_nvidia = new ToolStripMenuItem();
            tsr_amdGrafica = new ToolStripMenuItem();
            tsc_memorias = new ToolStripMenuItem();
            tsr_ddr4 = new ToolStripMenuItem();
            tsr_ddr5 = new ToolStripMenuItem();
            tsc_almacenamiento = new ToolStripMenuItem();
            tsr_ssd = new ToolStripMenuItem();
            tsr_hdd = new ToolStripMenuItem();
            westernDigitalToolStripMenuItem1 = new ToolStripMenuItem();
            seagateToolStripMenuItem = new ToolStripMenuItem();
            tsc_mother = new ToolStripMenuItem();
            str_AmdMother = new ToolStripMenuItem();
            str_IntelMother = new ToolStripMenuItem();
            tsc_perifericos = new ToolStripMenuItem();
            tsr_teclados = new ToolStripMenuItem();
            tsr_auriculares = new ToolStripMenuItem();
            tsr_mouse = new ToolStripMenuItem();
            tsr_parlantes = new ToolStripMenuItem();
            tsr_microfonos = new ToolStripMenuItem();
            tsr_sillas = new ToolStripMenuItem();
            tsr_camaras = new ToolStripMenuItem();
            tsr_monitores = new ToolStripMenuItem();
            aRMÁTUPCToolStripMenuItem = new ToolStripMenuItem();
            mODOOSCUROToolStripMenuItem = new ToolStripMenuItem();
            mICARRITOToolStripMenuItem = new ToolStripMenuItem();
            mns_header = new MenuStrip();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnBarraContenedora = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            panel7 = new Panel();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            panel8 = new Panel();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            iconButton10 = new FontAwesome.Sharp.IconButton();
            tmrBarra = new System.Windows.Forms.Timer(components);
            mns_header.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // tsr_busqueda
            // 
            tsr_busqueda.DropDownItems.AddRange(new ToolStripItem[] { tsc_procesadores, tsc_graficas, tsc_memorias, tsc_almacenamiento, tsc_mother, tsc_perifericos });
            tsr_busqueda.Name = "tsr_busqueda";
            tsr_busqueda.Size = new Size(162, 19);
            tsr_busqueda.Text = "BÚSQUEDA POR CATEGORÍA";
            // 
            // tsc_procesadores
            // 
            tsc_procesadores.BackColor = SystemColors.InactiveCaption;
            tsc_procesadores.DropDownItems.AddRange(new ToolStripItem[] { tsr_intel, tsr_amdProcesador });
            tsc_procesadores.Name = "tsc_procesadores";
            tsc_procesadores.Size = new Size(165, 22);
            tsc_procesadores.Text = "Procesadores";
            tsc_procesadores.TextAlign = ContentAlignment.TopCenter;
            // 
            // tsr_intel
            // 
            tsr_intel.Name = "tsr_intel";
            tsr_intel.Size = new Size(101, 22);
            tsr_intel.Text = "Intel";
            tsr_intel.Click += tsr_intel_Click;
            // 
            // tsr_amdProcesador
            // 
            tsr_amdProcesador.Name = "tsr_amdProcesador";
            tsr_amdProcesador.Size = new Size(101, 22);
            tsr_amdProcesador.Text = "AMD";
            tsr_amdProcesador.Click += tsr_amdProcesador_Click;
            // 
            // tsc_graficas
            // 
            tsc_graficas.BackColor = SystemColors.InactiveCaption;
            tsc_graficas.DropDownItems.AddRange(new ToolStripItem[] { tsr_nvidia, tsr_amdGrafica });
            tsc_graficas.Name = "tsc_graficas";
            tsc_graficas.Size = new Size(165, 22);
            tsc_graficas.Text = "Tarjetas gráficas";
            // 
            // tsr_nvidia
            // 
            tsr_nvidia.Name = "tsr_nvidia";
            tsr_nvidia.Size = new Size(108, 22);
            tsr_nvidia.Text = "Nvidia";
            tsr_nvidia.Click += tsr_nvidia_Click;
            // 
            // tsr_amdGrafica
            // 
            tsr_amdGrafica.Name = "tsr_amdGrafica";
            tsr_amdGrafica.Size = new Size(108, 22);
            tsr_amdGrafica.Text = "AMD";
            tsr_amdGrafica.Click += tsr_amdGrafica_Click;
            // 
            // tsc_memorias
            // 
            tsc_memorias.BackColor = SystemColors.InactiveCaption;
            tsc_memorias.DropDownItems.AddRange(new ToolStripItem[] { tsr_ddr4, tsr_ddr5 });
            tsc_memorias.Name = "tsc_memorias";
            tsc_memorias.Size = new Size(165, 22);
            tsc_memorias.Text = "Memorias";
            // 
            // tsr_ddr4
            // 
            tsr_ddr4.Name = "tsr_ddr4";
            tsr_ddr4.Size = new Size(103, 22);
            tsr_ddr4.Text = "DDR4";
            tsr_ddr4.Click += tsr_ddr4_Click;
            // 
            // tsr_ddr5
            // 
            tsr_ddr5.Name = "tsr_ddr5";
            tsr_ddr5.Size = new Size(103, 22);
            tsr_ddr5.Text = "DDR5";
            tsr_ddr5.Click += tsr_ddr5_Click;
            // 
            // tsc_almacenamiento
            // 
            tsc_almacenamiento.BackColor = SystemColors.InactiveCaption;
            tsc_almacenamiento.DropDownItems.AddRange(new ToolStripItem[] { tsr_ssd, tsr_hdd });
            tsc_almacenamiento.Name = "tsc_almacenamiento";
            tsc_almacenamiento.Size = new Size(165, 22);
            tsc_almacenamiento.Text = "Almacenamiento";
            // 
            // tsr_ssd
            // 
            tsr_ssd.Name = "tsr_ssd";
            tsr_ssd.Size = new Size(136, 22);
            tsr_ssd.Text = "Discos SSD";
            tsr_ssd.Click += tsr_ssd_Click;
            // 
            // tsr_hdd
            // 
            tsr_hdd.DropDownItems.AddRange(new ToolStripItem[] { westernDigitalToolStripMenuItem1, seagateToolStripMenuItem });
            tsr_hdd.Name = "tsr_hdd";
            tsr_hdd.Size = new Size(136, 22);
            tsr_hdd.Text = "Discos HDD";
            tsr_hdd.Click += tsr_hdd_Click;
            // 
            // westernDigitalToolStripMenuItem1
            // 
            westernDigitalToolStripMenuItem1.Name = "westernDigitalToolStripMenuItem1";
            westernDigitalToolStripMenuItem1.Size = new Size(154, 22);
            westernDigitalToolStripMenuItem1.Text = "Western Digital";
            // 
            // seagateToolStripMenuItem
            // 
            seagateToolStripMenuItem.Name = "seagateToolStripMenuItem";
            seagateToolStripMenuItem.Size = new Size(154, 22);
            seagateToolStripMenuItem.Text = "Seagate";
            // 
            // tsc_mother
            // 
            tsc_mother.BackColor = SystemColors.InactiveCaption;
            tsc_mother.DropDownItems.AddRange(new ToolStripItem[] { str_AmdMother, str_IntelMother });
            tsc_mother.Name = "tsc_mother";
            tsc_mother.Size = new Size(165, 22);
            tsc_mother.Text = "Mother";
            // 
            // str_AmdMother
            // 
            str_AmdMother.Name = "str_AmdMother";
            str_AmdMother.Size = new Size(101, 22);
            str_AmdMother.Text = "AMD";
            // 
            // str_IntelMother
            // 
            str_IntelMother.Name = "str_IntelMother";
            str_IntelMother.Size = new Size(101, 22);
            str_IntelMother.Text = "Intel";
            // 
            // tsc_perifericos
            // 
            tsc_perifericos.BackColor = SystemColors.InactiveCaption;
            tsc_perifericos.DropDownItems.AddRange(new ToolStripItem[] { tsr_teclados, tsr_auriculares, tsr_mouse, tsr_parlantes, tsr_microfonos, tsr_sillas, tsr_camaras, tsr_monitores });
            tsc_perifericos.Name = "tsc_perifericos";
            tsc_perifericos.Size = new Size(165, 22);
            tsc_perifericos.Text = "Periféricos";
            // 
            // tsr_teclados
            // 
            tsr_teclados.Name = "tsr_teclados";
            tsr_teclados.Size = new Size(135, 22);
            tsr_teclados.Text = "Teclados";
            tsr_teclados.Click += tsr_teclados_Click;
            // 
            // tsr_auriculares
            // 
            tsr_auriculares.Name = "tsr_auriculares";
            tsr_auriculares.Size = new Size(135, 22);
            tsr_auriculares.Text = "Auriculares";
            tsr_auriculares.Click += tsr_auriculares_Click;
            // 
            // tsr_mouse
            // 
            tsr_mouse.Name = "tsr_mouse";
            tsr_mouse.Size = new Size(135, 22);
            tsr_mouse.Text = "Mouse";
            tsr_mouse.Click += tsr_mouse_Click;
            // 
            // tsr_parlantes
            // 
            tsr_parlantes.Name = "tsr_parlantes";
            tsr_parlantes.Size = new Size(135, 22);
            tsr_parlantes.Text = "Parlantes";
            tsr_parlantes.Click += tsr_parlantes_Click;
            // 
            // tsr_microfonos
            // 
            tsr_microfonos.Name = "tsr_microfonos";
            tsr_microfonos.Size = new Size(135, 22);
            tsr_microfonos.Text = "Microfonos";
            tsr_microfonos.Click += tsr_microfonos_Click;
            // 
            // tsr_sillas
            // 
            tsr_sillas.Name = "tsr_sillas";
            tsr_sillas.Size = new Size(135, 22);
            tsr_sillas.Text = "Sillas";
            tsr_sillas.Click += tsr_sillas_Click;
            // 
            // tsr_camaras
            // 
            tsr_camaras.Name = "tsr_camaras";
            tsr_camaras.Size = new Size(135, 22);
            tsr_camaras.Text = "Cámaras";
            tsr_camaras.Click += tsr_camaras_Click;
            // 
            // tsr_monitores
            // 
            tsr_monitores.Name = "tsr_monitores";
            tsr_monitores.Size = new Size(135, 22);
            tsr_monitores.Text = "Monitores";
            tsr_monitores.Click += tsr_monitores_Click;
            // 
            // aRMÁTUPCToolStripMenuItem
            // 
            aRMÁTUPCToolStripMenuItem.Name = "aRMÁTUPCToolStripMenuItem";
            aRMÁTUPCToolStripMenuItem.Size = new Size(162, 19);
            aRMÁTUPCToolStripMenuItem.Text = "ARMÁ TU PC";
            // 
            // mODOOSCUROToolStripMenuItem
            // 
            mODOOSCUROToolStripMenuItem.Name = "mODOOSCUROToolStripMenuItem";
            mODOOSCUROToolStripMenuItem.Size = new Size(162, 19);
            mODOOSCUROToolStripMenuItem.Text = "MODO OSCURO";
            // 
            // mICARRITOToolStripMenuItem
            // 
            mICARRITOToolStripMenuItem.Name = "mICARRITOToolStripMenuItem";
            mICARRITOToolStripMenuItem.Size = new Size(162, 19);
            mICARRITOToolStripMenuItem.Text = "MI CARRITO";
            // 
            // mns_header
            // 
            mns_header.BackColor = SystemColors.ControlDark;
            mns_header.Dock = DockStyle.Right;
            mns_header.Items.AddRange(new ToolStripItem[] { tsr_busqueda, aRMÁTUPCToolStripMenuItem, mODOOSCUROToolStripMenuItem, mICARRITOToolStripMenuItem });
            mns_header.Location = new Point(1252, 0);
            mns_header.Name = "mns_header";
            mns_header.Padding = new Padding(7, 3, 0, 3);
            mns_header.Size = new Size(177, 1061);
            mns_header.TabIndex = 3;
            mns_header.Text = "menuStrip2";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(20, 18, 18);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Controls.Add(panel11);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(245, 1061);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBarraContenedora);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 99);
            panel1.TabIndex = 0;
            // 
            // btnBarraContenedora
            // 
            btnBarraContenedora.FlatAppearance.BorderSize = 0;
            btnBarraContenedora.FlatStyle = FlatStyle.Flat;
            btnBarraContenedora.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBarraContenedora.ForeColor = Color.White;
            btnBarraContenedora.IconChar = FontAwesome.Sharp.IconChar.List;
            btnBarraContenedora.IconColor = Color.DimGray;
            btnBarraContenedora.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnBarraContenedora.ImageAlign = ContentAlignment.MiddleLeft;
            btnBarraContenedora.Location = new Point(0, 0);
            btnBarraContenedora.Margin = new Padding(3, 4, 3, 4);
            btnBarraContenedora.Name = "btnBarraContenedora";
            btnBarraContenedora.Size = new Size(239, 99);
            btnBarraContenedora.TabIndex = 1;
            btnBarraContenedora.Tag = "";
            btnBarraContenedora.Text = "Menú";
            btnBarraContenedora.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton2);
            panel2.Location = new Point(3, 111);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 84);
            panel2.TabIndex = 1;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton2.IconColor = Color.DimGray;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 0);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(239, 84);
            iconButton2.TabIndex = 0;
            iconButton2.Text = "Inicio";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconButton3);
            panel3.Location = new Point(3, 203);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 84);
            panel3.TabIndex = 2;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.FolderClosed;
            iconButton3.IconColor = Color.DimGray;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 0);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(239, 84);
            iconButton3.TabIndex = 0;
            iconButton3.Text = "Categorías";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(iconButton4);
            panel4.Location = new Point(3, 295);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 84);
            panel4.TabIndex = 3;
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            iconButton4.IconColor = Color.DimGray;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 0);
            iconButton4.Margin = new Padding(3, 4, 3, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(239, 84);
            iconButton4.TabIndex = 0;
            iconButton4.Text = "Armá tu PC";
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(iconButton5);
            panel5.Location = new Point(3, 387);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(239, 84);
            panel5.TabIndex = 4;
            // 
            // iconButton5
            // 
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Moon;
            iconButton5.IconColor = Color.DimGray;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(0, 0);
            iconButton5.Margin = new Padding(3, 4, 3, 4);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(239, 84);
            iconButton5.TabIndex = 0;
            iconButton5.Text = "Modo oscuro";
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(iconButton6);
            panel6.Location = new Point(3, 479);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(239, 84);
            panel6.TabIndex = 5;
            // 
            // iconButton6
            // 
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            iconButton6.IconColor = Color.DimGray;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(0, 0);
            iconButton6.Margin = new Padding(3, 4, 3, 4);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(239, 84);
            iconButton6.TabIndex = 0;
            iconButton6.Text = "Mi carrito";
            iconButton6.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(iconButton7);
            panel7.Location = new Point(3, 571);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(239, 84);
            panel7.TabIndex = 6;
            // 
            // iconButton7
            // 
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconButton7.IconColor = Color.DimGray;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(0, 0);
            iconButton7.Margin = new Padding(3, 4, 3, 4);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(239, 84);
            iconButton7.TabIndex = 0;
            iconButton7.Text = "Contáctanos";
            iconButton7.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(iconButton8);
            panel8.Location = new Point(3, 663);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(239, 84);
            panel8.TabIndex = 7;
            // 
            // iconButton8
            // 
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton8.ForeColor = Color.White;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.Building;
            iconButton8.IconColor = Color.DimGray;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton8.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton8.Location = new Point(0, 0);
            iconButton8.Margin = new Padding(3, 4, 3, 4);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(239, 84);
            iconButton8.TabIndex = 0;
            iconButton8.Text = "Nosotros";
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Location = new Point(3, 755);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(239, 84);
            panel9.TabIndex = 8;
            // 
            // panel10
            // 
            panel10.Location = new Point(3, 847);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(239, 80);
            panel10.TabIndex = 9;
            // 
            // panel11
            // 
            panel11.Controls.Add(iconButton10);
            panel11.Location = new Point(3, 935);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(239, 80);
            panel11.TabIndex = 10;
            // 
            // iconButton10
            // 
            iconButton10.FlatAppearance.BorderSize = 0;
            iconButton10.FlatStyle = FlatStyle.Flat;
            iconButton10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton10.ForeColor = Color.White;
            iconButton10.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            iconButton10.IconColor = Color.DimGray;
            iconButton10.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton10.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton10.Location = new Point(0, 0);
            iconButton10.Margin = new Padding(3, 4, 3, 4);
            iconButton10.Name = "iconButton10";
            iconButton10.Size = new Size(239, 80);
            iconButton10.TabIndex = 0;
            iconButton10.Text = "Cerrar sesión";
            iconButton10.UseVisualStyleBackColor = true;
            // 
            // tmrBarra
            // 
            tmrBarra.Interval = 10;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1429, 1061);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(mns_header);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Byte Bay";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            mns_header.ResumeLayout(false);
            mns_header.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem tsr_busqueda;
        private ToolStripMenuItem tsc_procesadores;
        private ToolStripMenuItem tsr_intel;
        private ToolStripMenuItem tsr_amdProcesador;
        private ToolStripMenuItem tsc_graficas;
        private ToolStripMenuItem tsr_nvidia;
        private ToolStripMenuItem tsr_amdGrafica;
        private ToolStripMenuItem tsc_memorias;
        private ToolStripMenuItem tsr_ddr4;
        private ToolStripMenuItem tsr_ddr5;
        private ToolStripMenuItem tsc_almacenamiento;
        private ToolStripMenuItem tsr_ssd;
        private ToolStripMenuItem tsr_hdd;
        private ToolStripMenuItem westernDigitalToolStripMenuItem1;
        private ToolStripMenuItem seagateToolStripMenuItem;
        private ToolStripMenuItem tsc_mother;
        private ToolStripMenuItem str_AmdMother;
        private ToolStripMenuItem str_IntelMother;
        private ToolStripMenuItem tsc_perifericos;
        private ToolStripMenuItem tsr_teclados;
        private ToolStripMenuItem tsr_auriculares;
        private ToolStripMenuItem tsr_mouse;
        private ToolStripMenuItem tsr_parlantes;
        private ToolStripMenuItem tsr_microfonos;
        private ToolStripMenuItem tsr_sillas;
        private ToolStripMenuItem tsr_camaras;
        private ToolStripMenuItem tsr_monitores;
        private ToolStripMenuItem aRMÁTUPCToolStripMenuItem;
        private ToolStripMenuItem mODOOSCUROToolStripMenuItem;
        private ToolStripMenuItem mICARRITOToolStripMenuItem;
        private MenuStrip mns_header;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnBarraContenedora;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton iconButton6;
        private Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton7;
        private Panel panel8;
        private FontAwesome.Sharp.IconButton iconButton8;
        private Panel panel9;
        private System.Windows.Forms.Timer tmrBarra;
        private Panel panel10;
        private Panel panel11;
        private FontAwesome.Sharp.IconButton iconButton10;
    }
}