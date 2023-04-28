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
            Logout = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            listAllCursos = new System.Windows.Forms.Button();
            listMyCursos = new System.Windows.Forms.Button();
            ModificarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Logout
            // 
            Logout.Location = new System.Drawing.Point(593, -3);
            Logout.Name = "Logout";
            Logout.Size = new System.Drawing.Size(102, 50);
            Logout.TabIndex = 0;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(696, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(-1, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(100, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(341, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // listAllCursos
            // 
            listAllCursos.Location = new System.Drawing.Point(249, 112);
            listAllCursos.Name = "listAllCursos";
            listAllCursos.Size = new System.Drawing.Size(206, 50);
            listAllCursos.TabIndex = 4;
            listAllCursos.Text = "Ver todos los Cursos";
            listAllCursos.UseVisualStyleBackColor = true;
            listAllCursos.Click += listAllCursos_Click;
            // 
            // listMyCursos
            // 
            listMyCursos.Location = new System.Drawing.Point(249, 195);
            listMyCursos.Name = "listMyCursos";
            listMyCursos.Size = new System.Drawing.Size(206, 50);
            listMyCursos.TabIndex = 5;
            listMyCursos.Text = "Ver Mis Cursos";
            listMyCursos.UseVisualStyleBackColor = true;
            listMyCursos.Click += listMyCursos_Click;
            // 
            // ModificarDatos
            // 
            ModificarDatos.Location = new System.Drawing.Point(249, 283);
            ModificarDatos.Name = "ModificarDatos";
            ModificarDatos.Size = new System.Drawing.Size(206, 50);
            ModificarDatos.TabIndex = 6;
            ModificarDatos.Text = "Modificar Datos Personales";
            ModificarDatos.UseVisualStyleBackColor = true;
            ModificarDatos.Click += ModificarDatos_Click;
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(695, 450);
            Controls.Add(ModificarDatos);
            Controls.Add(listMyCursos);
            Controls.Add(listAllCursos);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(Logout);
            Controls.Add(pictureBox1);
            Name = "MenuCliente";
            Text = "MenuCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button listAllCursos;
        private System.Windows.Forms.Button listMyCursos;
        private System.Windows.Forms.Button ModificarDatos;
    }
}