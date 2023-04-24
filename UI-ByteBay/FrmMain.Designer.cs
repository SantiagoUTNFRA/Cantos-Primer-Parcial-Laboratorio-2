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
            mns_header.SuspendLayout();
            SuspendLayout();
            // 
            // tsr_busqueda
            // 
            tsr_busqueda.DropDownItems.AddRange(new ToolStripItem[] { tsc_procesadores, tsc_graficas, tsc_memorias, tsc_almacenamiento, tsc_mother, tsc_perifericos });
            tsr_busqueda.Name = "tsr_busqueda";
            tsr_busqueda.Size = new Size(170, 20);
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
            aRMÁTUPCToolStripMenuItem.Size = new Size(88, 20);
            aRMÁTUPCToolStripMenuItem.Text = "ARMÁ TU PC";
            // 
            // mODOOSCUROToolStripMenuItem
            // 
            mODOOSCUROToolStripMenuItem.Name = "mODOOSCUROToolStripMenuItem";
            mODOOSCUROToolStripMenuItem.Size = new Size(106, 20);
            mODOOSCUROToolStripMenuItem.Text = "MODO OSCURO";
            // 
            // mICARRITOToolStripMenuItem
            // 
            mICARRITOToolStripMenuItem.Name = "mICARRITOToolStripMenuItem";
            mICARRITOToolStripMenuItem.Size = new Size(83, 20);
            mICARRITOToolStripMenuItem.Text = "MI CARRITO";
            // 
            // mns_header
            // 
            mns_header.BackColor = SystemColors.ControlDark;
            mns_header.Items.AddRange(new ToolStripItem[] { tsr_busqueda, aRMÁTUPCToolStripMenuItem, mODOOSCUROToolStripMenuItem, mICARRITOToolStripMenuItem });
            mns_header.Location = new Point(0, 0);
            mns_header.Name = "mns_header";
            mns_header.Size = new Size(1250, 24);
            mns_header.TabIndex = 3;
            mns_header.Text = "menuStrip2";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1250, 692);
            Controls.Add(mns_header);
            IsMdiContainer = true;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            mns_header.ResumeLayout(false);
            mns_header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
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
    }
}