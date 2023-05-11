namespace DotNet_GenteFit
{
    partial class MenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCliente));
            Logout = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            listAllCursos = new System.Windows.Forms.Button();
            listMyCursos = new System.Windows.Forms.Button();
            ModificarDatos = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Logout
            // 
            Logout.Location = new System.Drawing.Point(678, -3);
            Logout.Name = "Logout";
            Logout.Size = new System.Drawing.Size(117, 47);
            Logout.TabIndex = 0;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(795, 47);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(-1, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(114, 47);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // listAllCursos
            // 
            listAllCursos.Location = new System.Drawing.Point(285, 105);
            listAllCursos.Name = "listAllCursos";
            listAllCursos.Size = new System.Drawing.Size(235, 47);
            listAllCursos.TabIndex = 4;
            listAllCursos.Text = "Ver todos los Cursos";
            listAllCursos.UseVisualStyleBackColor = true;
            listAllCursos.Click += listAllCursos_Click;
            // 
            // listMyCursos
            // 
            listMyCursos.Location = new System.Drawing.Point(285, 182);
            listMyCursos.Name = "listMyCursos";
            listMyCursos.Size = new System.Drawing.Size(235, 47);
            listMyCursos.TabIndex = 5;
            listMyCursos.Text = "Ver Mis Cursos";
            listMyCursos.UseVisualStyleBackColor = true;
            listMyCursos.Click += listMyCursos_Click;
            // 
            // ModificarDatos
            // 
            ModificarDatos.Location = new System.Drawing.Point(285, 264);
            ModificarDatos.Name = "ModificarDatos";
            ModificarDatos.Size = new System.Drawing.Size(235, 47);
            ModificarDatos.TabIndex = 6;
            ModificarDatos.Text = "Modificar Datos Personales";
            ModificarDatos.UseVisualStyleBackColor = true;
            ModificarDatos.Click += ModificarDatos_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logojpg;
            pictureBox3.Location = new System.Drawing.Point(17, 50);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(96, 102);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateBlue;
            ClientSize = new System.Drawing.Size(796, 411);
            Controls.Add(pictureBox3);
            Controls.Add(ModificarDatos);
            Controls.Add(listMyCursos);
            Controls.Add(listAllCursos);
            Controls.Add(pictureBox2);
            Controls.Add(Logout);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MenuCliente";
            Text = "MenuCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button listAllCursos;
        private System.Windows.Forms.Button listMyCursos;
        private System.Windows.Forms.Button ModificarDatos;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}