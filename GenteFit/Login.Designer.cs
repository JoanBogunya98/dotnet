namespace DotNet_GenteFit
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            IniciarSesion = new System.Windows.Forms.Button();
            registrarse = new System.Windows.Forms.Button();
            textBoxContraseña = new System.Windows.Forms.TextBox();
            textBoxUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(747, 47);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(114, 47);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // IniciarSesion
            // 
            IniciarSesion.Location = new System.Drawing.Point(303, 180);
            IniciarSesion.Name = "IniciarSesion";
            IniciarSesion.Size = new System.Drawing.Size(117, 26);
            IniciarSesion.TabIndex = 3;
            IniciarSesion.Text = "Iniciar sesión";
            IniciarSesion.UseVisualStyleBackColor = true;
            IniciarSesion.Click += login_Click;
            // 
            // registrarse
            // 
            registrarse.Location = new System.Drawing.Point(303, 230);
            registrarse.Name = "registrarse";
            registrarse.Size = new System.Drawing.Size(117, 26);
            registrarse.TabIndex = 4;
            registrarse.Text = "Registrarse";
            registrarse.UseVisualStyleBackColor = true;
            registrarse.Click += registro_Click;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new System.Drawing.Point(282, 129);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PlaceholderText = "Contraseña";
            textBoxContraseña.Size = new System.Drawing.Size(154, 22);
            textBoxContraseña.TabIndex = 5;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new System.Drawing.Point(282, 85);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Usuario";
            textBoxUsuario.Size = new System.Drawing.Size(154, 22);
            textBoxUsuario.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateBlue;
            ClientSize = new System.Drawing.Size(750, 420);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBoxContraseña);
            Controls.Add(registrarse);
            Controls.Add(IniciarSesion);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.Button registrarse;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxUsuario;
    }
}