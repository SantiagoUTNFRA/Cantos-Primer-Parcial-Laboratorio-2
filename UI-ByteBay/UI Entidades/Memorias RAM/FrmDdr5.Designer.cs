namespace UI_ByteBay.UI_Entidades.Memorias_RAM
{
    partial class FrmDdr5
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
            faProvider1 = new FontAwesome.WinForms.FaProvider();
            faPicker1 = new FontAwesome.WinForms.FaPicker();
            SuspendLayout();
            // 
            // faProvider1
            // 
            faProvider1.Icon = "";
            faProvider1.IconColor = Color.DodgerBlue;
            faProvider1.IconPadding = 0;
            faProvider1.IconSize = 128;
            faProvider1.ImageListBinding = null;
            // 
            // faPicker1
            // 
            faPicker1.BackColor = Color.Transparent;
            faPicker1.Location = new Point(40, 39);
            faPicker1.Margin = new Padding(4, 3, 4, 3);
            faPicker1.Name = "faPicker1";
            faPicker1.Size = new Size(55, 46);
            faPicker1.TabIndex = 0;
            faPicker1.Visible = false;
            // 
            // FrmDdr5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(faPicker1);
            Name = "FrmDdr5";
            Text = "FrmDdr5 asd ";
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.WinForms.FaProvider faProvider1;
        private FontAwesome.WinForms.FaPicker faPicker1;
    }
}