﻿namespace UI_ByteBay.UI_Entidades
{
    partial class FrmGenerico
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
            SuspendLayout();
            // 
            // faProvider1
            // 
            faProvider1.Icon = "Home";
            faProvider1.IconColor = Color.AliceBlue;
            faProvider1.IconPadding = 0;
            faProvider1.IconSize = 128;
            faProvider1.ImageListBinding = null;
            // 
            // FrmGenerico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 533);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGenerico";
            Text = "ClaseBaseTest";
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.WinForms.FaProvider faProvider1;
    }
}