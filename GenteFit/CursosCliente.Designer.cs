﻿namespace DotNet_GenteFit
{
    partial class CursosCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursosCliente));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            logout = new System.Windows.Forms.Button();
            menu = new System.Windows.Forms.Button();
            cursos = new System.Windows.Forms.ListBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            cmdSuscribirse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(913, 47);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(115, 47);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // logout
            // 
            logout.Location = new System.Drawing.Point(800, 1);
            logout.Name = "logout";
            logout.Size = new System.Drawing.Size(114, 47);
            logout.TabIndex = 2;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // menu
            // 
            menu.Location = new System.Drawing.Point(679, 1);
            menu.Name = "menu";
            menu.Size = new System.Drawing.Size(114, 47);
            menu.TabIndex = 3;
            menu.Text = "Menú";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // cursos
            // 
            cursos.FormattingEnabled = true;
            cursos.ItemHeight = 14;
            cursos.Location = new System.Drawing.Point(129, 67);
            cursos.Name = "cursos";
            cursos.Size = new System.Drawing.Size(738, 298);
            cursos.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logojpg;
            pictureBox3.Location = new System.Drawing.Point(12, 67);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(96, 102);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // cmdSuscribirse
            // 
            cmdSuscribirse.Location = new System.Drawing.Point(705, 376);
            cmdSuscribirse.Name = "cmdSuscribirse";
            cmdSuscribirse.Size = new System.Drawing.Size(162, 23);
            cmdSuscribirse.TabIndex = 7;
            cmdSuscribirse.Text = "Subscribirse";
            cmdSuscribirse.UseVisualStyleBackColor = true;
            cmdSuscribirse.Click += cmdSuscribirse_Click;
            // 
            // CursosCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateBlue;
            ClientSize = new System.Drawing.Size(914, 420);
            Controls.Add(cmdSuscribirse);
            Controls.Add(pictureBox3);
            Controls.Add(cursos);
            Controls.Add(menu);
            Controls.Add(logout);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "CursosCliente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CursosCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.ListBox cursos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button cmdSuscribirse;
    }
}