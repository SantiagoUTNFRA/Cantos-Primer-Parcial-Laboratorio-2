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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnIniciarSesionInvitado = new FontAwesome.Sharp.IconButton();
            btnRegistrarse = new FontAwesome.Sharp.IconButton();
            tbcAll = new TabControl();
            tpIniciar = new TabPage();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            txtContrasenia = new TextBox();
            txtUsuario = new TextBox();
            label5 = new Label();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            label6 = new Label();
            btnIniciar = new FontAwesome.Sharp.IconButton();
            tpRegistrarse = new TabPage();
            btnRegistro = new FontAwesome.Sharp.IconButton();
            txtDniRegistro = new TextBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtContraseniaRegistro = new TextBox();
            txtUsuarioRegistro = new TextBox();
            label1 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tbcAll.SuspendLayout();
            tpIniciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            tpRegistrarse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnIniciarSesion, "btnIniciarSesion");
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            btnIniciarSesion.IconColor = Color.DimGray;
            btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Tag = "";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnIniciarSesionInvitado);
            panel1.Controls.Add(btnRegistrarse);
            panel1.Controls.Add(btnIniciarSesion);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // btnIniciarSesionInvitado
            // 
            btnIniciarSesionInvitado.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnIniciarSesionInvitado, "btnIniciarSesionInvitado");
            btnIniciarSesionInvitado.ForeColor = Color.White;
            btnIniciarSesionInvitado.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            btnIniciarSesionInvitado.IconColor = Color.DimGray;
            btnIniciarSesionInvitado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnIniciarSesionInvitado.Name = "btnIniciarSesionInvitado";
            btnIniciarSesionInvitado.Tag = "";
            btnIniciarSesionInvitado.UseVisualStyleBackColor = true;
            btnIniciarSesionInvitado.Click += btnIniciarSesionInvitado_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnRegistrarse, "btnRegistrarse");
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnRegistrarse.IconColor = Color.DimGray;
            btnRegistrarse.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Tag = "";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // tbcAll
            // 
            resources.ApplyResources(tbcAll, "tbcAll");
            tbcAll.Controls.Add(tpIniciar);
            tbcAll.Controls.Add(tpRegistrarse);
            tbcAll.Name = "tbcAll";
            tbcAll.SelectedIndex = 0;
            // 
            // tpIniciar
            // 
            tpIniciar.BackColor = Color.FromArgb(20, 18, 18);
            tpIniciar.Controls.Add(iconPictureBox5);
            tpIniciar.Controls.Add(txtContrasenia);
            tpIniciar.Controls.Add(txtUsuario);
            tpIniciar.Controls.Add(label5);
            tpIniciar.Controls.Add(iconPictureBox6);
            tpIniciar.Controls.Add(label6);
            tpIniciar.Controls.Add(btnIniciar);
            resources.ApplyResources(tpIniciar, "tpIniciar");
            tpIniciar.Name = "tpIniciar";
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.FromArgb(20, 18, 18);
            iconPictureBox5.ForeColor = Color.DimGray;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox5.IconColor = Color.DimGray;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 52;
            resources.ApplyResources(iconPictureBox5, "iconPictureBox5");
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.TabStop = false;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = Color.FromArgb(20, 18, 18);
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtContrasenia, "txtContrasenia");
            txtContrasenia.ForeColor = Color.White;
            txtContrasenia.Name = "txtContrasenia";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(20, 18, 18);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Name = "txtUsuario";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.White;
            label5.Name = "label5";
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.FromArgb(20, 18, 18);
            iconPictureBox6.ForeColor = Color.DimGray;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox6.IconColor = Color.DimGray;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 52;
            resources.ApplyResources(iconPictureBox6, "iconPictureBox6");
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.White;
            label6.Name = "label6";
            // 
            // btnIniciar
            // 
            btnIniciar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnIniciar, "btnIniciar");
            btnIniciar.ForeColor = Color.White;
            btnIniciar.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            btnIniciar.IconColor = Color.DimGray;
            btnIniciar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Tag = "";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // tpRegistrarse
            // 
            tpRegistrarse.BackColor = Color.FromArgb(20, 18, 18);
            tpRegistrarse.Controls.Add(btnRegistro);
            tpRegistrarse.Controls.Add(txtDniRegistro);
            tpRegistrarse.Controls.Add(iconPictureBox3);
            tpRegistrarse.Controls.Add(label3);
            tpRegistrarse.Controls.Add(iconPictureBox1);
            tpRegistrarse.Controls.Add(txtContraseniaRegistro);
            tpRegistrarse.Controls.Add(txtUsuarioRegistro);
            tpRegistrarse.Controls.Add(label1);
            tpRegistrarse.Controls.Add(iconPictureBox2);
            tpRegistrarse.Controls.Add(label2);
            resources.ApplyResources(tpRegistrarse, "tpRegistrarse");
            tpRegistrarse.Name = "tpRegistrarse";
            // 
            // btnRegistro
            // 
            btnRegistro.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnRegistro, "btnRegistro");
            btnRegistro.ForeColor = Color.White;
            btnRegistro.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            btnRegistro.IconColor = Color.DimGray;
            btnRegistro.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Tag = "";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // txtDniRegistro
            // 
            txtDniRegistro.BackColor = Color.FromArgb(20, 18, 18);
            txtDniRegistro.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtDniRegistro, "txtDniRegistro");
            txtDniRegistro.ForeColor = Color.White;
            txtDniRegistro.Name = "txtDniRegistro";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(20, 18, 18);
            iconPictureBox3.ForeColor = Color.DimGray;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            iconPictureBox3.IconColor = Color.DimGray;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 52;
            resources.ApplyResources(iconPictureBox3, "iconPictureBox3");
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.White;
            label3.Name = "label3";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(20, 18, 18);
            iconPictureBox1.ForeColor = Color.DimGray;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.DimGray;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 52;
            resources.ApplyResources(iconPictureBox1, "iconPictureBox1");
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.TabStop = false;
            // 
            // txtContraseniaRegistro
            // 
            txtContraseniaRegistro.BackColor = Color.FromArgb(20, 18, 18);
            txtContraseniaRegistro.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtContraseniaRegistro, "txtContraseniaRegistro");
            txtContraseniaRegistro.ForeColor = Color.White;
            txtContraseniaRegistro.Name = "txtContraseniaRegistro";
            // 
            // txtUsuarioRegistro
            // 
            txtUsuarioRegistro.BackColor = Color.FromArgb(20, 18, 18);
            txtUsuarioRegistro.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtUsuarioRegistro, "txtUsuarioRegistro");
            txtUsuarioRegistro.ForeColor = Color.White;
            txtUsuarioRegistro.Name = "txtUsuarioRegistro";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(20, 18, 18);
            iconPictureBox2.ForeColor = Color.DimGray;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox2.IconColor = Color.DimGray;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 52;
            resources.ApplyResources(iconPictureBox2, "iconPictureBox2");
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 18, 18);
            Controls.Add(tbcAll);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Login";
            panel1.ResumeLayout(false);
            tbcAll.ResumeLayout(false);
            tpIniciar.ResumeLayout(false);
            tpIniciar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            tpRegistrarse.ResumeLayout(false);
            tpRegistrarse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnRegistrarse;
        private FontAwesome.Sharp.IconButton btnIniciarSesionInvitado;
        private TabControl tbcAll;
        private TabPage tpIniciar;
        private TabPage tpRegistrarse;
        private FontAwesome.Sharp.IconButton btnIniciar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtContraseniaRegistro;
        private TextBox txtUsuarioRegistro;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label2;
        private TextBox txtDniRegistro;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private TextBox txtContrasenia;
        private TextBox txtUsuario;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnRegistro;
    }
}