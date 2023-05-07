namespace DotNet_GenteFit
{
    partial class MenuAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrador));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            logout = new System.Windows.Forms.Button();
            listAllCursos = new System.Windows.Forms.Button();
            listAllClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(758, 47);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(114, 47);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // logout
            // 
            logout.Location = new System.Drawing.Point(639, 0);
            logout.Name = "logout";
            logout.Size = new System.Drawing.Size(119, 47);
            logout.TabIndex = 2;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // listAllCursos
            // 
            listAllCursos.Location = new System.Drawing.Point(240, 131);
            listAllCursos.Name = "listAllCursos";
            listAllCursos.Size = new System.Drawing.Size(231, 47);
            listAllCursos.TabIndex = 3;
            listAllCursos.Text = "Ver Todos los Cursos";
            listAllCursos.UseVisualStyleBackColor = true;
            listAllCursos.Click += listAllCursos_Click;
            // 
            // listAllClientes
            // 
            listAllClientes.Location = new System.Drawing.Point(240, 205);
            listAllClientes.Name = "listAllClientes";
            listAllClientes.Size = new System.Drawing.Size(231, 47);
            listAllClientes.TabIndex = 4;
            listAllClientes.Text = "Ver Todos los Clientes";
            listAllClientes.UseVisualStyleBackColor = true;
            listAllClientes.Click += listAllClientes_Click;
            // 
            // MenuAdministrador
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateBlue;
            ClientSize = new System.Drawing.Size(755, 420);
            Controls.Add(listAllClientes);
            Controls.Add(listAllCursos);
            Controls.Add(logout);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MenuAdministrador";
            Text = "MenuAdministrador";
            Load += MenuAdministrador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button listAllCursos;
        private System.Windows.Forms.Button listAllClientes;
    }
}