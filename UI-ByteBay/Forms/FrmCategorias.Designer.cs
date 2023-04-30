namespace UI_ByteBay
{
    partial class FrmCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvwCategoria = new ListView();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lvwCategoria
            // 
            lvwCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvwCategoria.Location = new Point(12, 68);
            lvwCategoria.Name = "lvwCategoria";
            lvwCategoria.Size = new Size(334, 629);
            lvwCategoria.TabIndex = 0;
            lvwCategoria.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 62);
            panel1.TabIndex = 1;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(988, 709);
            Controls.Add(panel1);
            Controls.Add(lvwCategoria);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCategorias";
            WindowState = FormWindowState.Maximized;
            Load += FrmCategorias_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListView lvwCategoria;
        private Panel panel1;
    }
}