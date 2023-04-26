namespace UI_ByteBay
{
    partial class Login
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
            txtUsuario = new TextBox();
            btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            ipcUsuario = new FontAwesome.Sharp.IconPictureBox();
            ipcContrasenia = new FontAwesome.Sharp.IconPictureBox();
            txtContrasenia = new TextBox();
            lblUsuario = new Label();
            lblContrasenia = new Label();
            ((System.ComponentModel.ISupportInitialize)ipcUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ipcContrasenia).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(20, 18, 18);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(503, 116);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(164, 35);
            txtUsuario.TabIndex = 1;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            btnIniciarSesion.IconColor = Color.DimGray;
            btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnIniciarSesion.Location = new Point(350, 287);
            btnIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(317, 99);
            btnIniciarSesion.TabIndex = 3;
            btnIniciarSesion.Tag = "";
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 437);
            panel1.TabIndex = 7;
            // 
            // ipcUsuario
            // 
            ipcUsuario.BackColor = Color.FromArgb(20, 18, 18);
            ipcUsuario.ForeColor = Color.DimGray;
            ipcUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            ipcUsuario.IconColor = Color.DimGray;
            ipcUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipcUsuario.IconSize = 52;
            ipcUsuario.Location = new Point(350, 97);
            ipcUsuario.Name = "ipcUsuario";
            ipcUsuario.Size = new Size(52, 54);
            ipcUsuario.TabIndex = 8;
            ipcUsuario.TabStop = false;
            // 
            // ipcContrasenia
            // 
            ipcContrasenia.BackColor = Color.FromArgb(20, 18, 18);
            ipcContrasenia.ForeColor = Color.DimGray;
            ipcContrasenia.IconChar = FontAwesome.Sharp.IconChar.Key;
            ipcContrasenia.IconColor = Color.DimGray;
            ipcContrasenia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipcContrasenia.IconSize = 52;
            ipcContrasenia.Location = new Point(350, 180);
            ipcContrasenia.Name = "ipcContrasenia";
            ipcContrasenia.Size = new Size(52, 54);
            ipcContrasenia.TabIndex = 10;
            ipcContrasenia.TabStop = false;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = Color.FromArgb(20, 18, 18);
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            txtContrasenia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasenia.ForeColor = Color.White;
            txtContrasenia.Location = new Point(503, 196);
            txtContrasenia.Multiline = true;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(164, 36);
            txtContrasenia.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(418, 116);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(65, 21);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasenia.ForeColor = Color.White;
            lblContrasenia.Location = new Point(408, 198);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(92, 21);
            lblContrasenia.TabIndex = 13;
            lblContrasenia.Text = "Contraseña";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 18, 18);
            ClientSize = new Size(807, 437);
            Controls.Add(lblContrasenia);
            Controls.Add(lblUsuario);
            Controls.Add(txtContrasenia);
            Controls.Add(ipcContrasenia);
            Controls.Add(ipcUsuario);
            Controls.Add(panel1);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtUsuario);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)ipcUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)ipcContrasenia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox ipcUsuario;
        private FontAwesome.Sharp.IconPictureBox ipcContrasenia;
        private TextBox txtContrasenia;
        private Label lblUsuario;
        private Label lblContrasenia;
    }
}