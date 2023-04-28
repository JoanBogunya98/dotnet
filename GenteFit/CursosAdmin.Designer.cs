namespace DotNet_GenteFit
{
    partial class CursosAdmin
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            logout = new System.Windows.Forms.Button();
            menu = new System.Windows.Forms.Button();
            addCurso = new System.Windows.Forms.Button();
            cursos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(798, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(100, 50);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // logout
            // 
            logout.Location = new System.Drawing.Point(699, -1);
            logout.Name = "logout";
            logout.Size = new System.Drawing.Size(99, 50);
            logout.TabIndex = 2;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // menu
            // 
            menu.Location = new System.Drawing.Point(594, -1);
            menu.Name = "menu";
            menu.Size = new System.Drawing.Size(99, 50);
            menu.TabIndex = 3;
            menu.Text = "Menú";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // addCurso
            // 
            addCurso.Location = new System.Drawing.Point(273, 302);
            addCurso.Name = "addCurso";
            addCurso.Size = new System.Drawing.Size(217, 50);
            addCurso.TabIndex = 4;
            addCurso.Text = "Insertar Nuevo Curso";
            addCurso.UseVisualStyleBackColor = true;
            addCurso.Click += addCurso_Click;
            // 
            // cursos
            // 
            cursos.FormattingEnabled = true;
            cursos.ItemHeight = 15;
            cursos.Location = new System.Drawing.Point(94, 111);
            cursos.Name = "cursos";
            cursos.Size = new System.Drawing.Size(588, 154);
            cursos.TabIndex = 5;
            cursos.SelectedIndexChanged += cursos_SelectedIndexChanged;
            // 
            // CursosAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(cursos);
            Controls.Add(addCurso);
            Controls.Add(menu);
            Controls.Add(logout);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "CursosAdmin";
            Text = "CursosAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button addCurso;
        private System.Windows.Forms.ListBox cursos;
    }
}