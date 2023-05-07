namespace DotNet_GenteFit
{
    partial class Registro
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
            txtUsername = new System.Windows.Forms.TextBox();
            txtCuentaBanco = new System.Windows.Forms.TextBox();
            txtDireccion = new System.Windows.Forms.TextBox();
            txtRepetirPassword = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            UsernameCliente = new System.Windows.Forms.Label();
            EmailCliente = new System.Windows.Forms.Label();
            PasswordCliente = new System.Windows.Forms.Label();
            RepeatPassword = new System.Windows.Forms.Label();
            DireccionCliente = new System.Windows.Forms.Label();
            FechanacimientoCliente = new System.Windows.Forms.Label();
            GeneroCliente = new System.Windows.Forms.Label();
            CuentaBanco = new System.Windows.Forms.Label();
            dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            cmbGenero = new System.Windows.Forms.ComboBox();
            registrarse = new System.Windows.Forms.Button();
            menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(143, 95);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(173, 22);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += textNombre_TextChanged;
            // 
            // txtCuentaBanco
            // 
            txtCuentaBanco.Location = new System.Drawing.Point(474, 260);
            txtCuentaBanco.Name = "txtCuentaBanco";
            txtCuentaBanco.Size = new System.Drawing.Size(272, 22);
            txtCuentaBanco.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(474, 95);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(272, 22);
            txtDireccion.TabIndex = 7;
            txtDireccion.TextChanged += textDireccion_TextChanged;
            // 
            // txtRepetirPassword
            // 
            txtRepetirPassword.Location = new System.Drawing.Point(143, 260);
            txtRepetirPassword.Name = "txtRepetirPassword";
            txtRepetirPassword.Size = new System.Drawing.Size(173, 22);
            txtRepetirPassword.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(143, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(173, 22);
            txtPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(143, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(173, 22);
            txtEmail.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(757, 47);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(114, 47);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // UsernameCliente
            // 
            UsernameCliente.AutoSize = true;
            UsernameCliente.Location = new System.Drawing.Point(3, 103);
            UsernameCliente.Name = "UsernameCliente";
            UsernameCliente.Size = new System.Drawing.Size(134, 14);
            UsernameCliente.TabIndex = 14;
            UsernameCliente.Text = "Nombre de Usuario";
            UsernameCliente.Click += label1_Click;
            // 
            // EmailCliente
            // 
            EmailCliente.AutoSize = true;
            EmailCliente.Location = new System.Drawing.Point(50, 161);
            EmailCliente.Name = "EmailCliente";
            EmailCliente.Size = new System.Drawing.Size(43, 14);
            EmailCliente.TabIndex = 15;
            EmailCliente.Text = "Email";
            // 
            // PasswordCliente
            // 
            PasswordCliente.AutoSize = true;
            PasswordCliente.Location = new System.Drawing.Point(38, 217);
            PasswordCliente.Name = "PasswordCliente";
            PasswordCliente.Size = new System.Drawing.Size(82, 14);
            PasswordCliente.TabIndex = 16;
            PasswordCliente.Text = "Contraseña";
            PasswordCliente.Click += Password_Click;
            // 
            // RepeatPassword
            // 
            RepeatPassword.AutoSize = true;
            RepeatPassword.Location = new System.Drawing.Point(0, 268);
            RepeatPassword.Name = "RepeatPassword";
            RepeatPassword.Size = new System.Drawing.Size(132, 14);
            RepeatPassword.TabIndex = 17;
            RepeatPassword.Text = "Repetir contraseña";
            // 
            // DireccionCliente
            // 
            DireccionCliente.AutoSize = true;
            DireccionCliente.Location = new System.Drawing.Point(392, 103);
            DireccionCliente.Name = "DireccionCliente";
            DireccionCliente.Size = new System.Drawing.Size(69, 14);
            DireccionCliente.TabIndex = 18;
            DireccionCliente.Text = "Dirección";
            DireccionCliente.Click += label5_Click;
            // 
            // FechanacimientoCliente
            // 
            FechanacimientoCliente.AutoSize = true;
            FechanacimientoCliente.Location = new System.Drawing.Point(334, 161);
            FechanacimientoCliente.Name = "FechanacimientoCliente";
            FechanacimientoCliente.Size = new System.Drawing.Size(142, 14);
            FechanacimientoCliente.TabIndex = 19;
            FechanacimientoCliente.Text = "Fecha de nacimiento";
            FechanacimientoCliente.Click += label6_Click;
            // 
            // GeneroCliente
            // 
            GeneroCliente.AutoSize = true;
            GeneroCliente.Location = new System.Drawing.Point(392, 217);
            GeneroCliente.Name = "GeneroCliente";
            GeneroCliente.Size = new System.Drawing.Size(55, 14);
            GeneroCliente.TabIndex = 20;
            GeneroCliente.Text = "Género";
            GeneroCliente.Click += label7_Click;
            // 
            // CuentaBanco
            // 
            CuentaBanco.AutoSize = true;
            CuentaBanco.Location = new System.Drawing.Point(353, 268);
            CuentaBanco.Name = "CuentaBanco";
            CuentaBanco.Size = new System.Drawing.Size(115, 14);
            CuentaBanco.TabIndex = 21;
            CuentaBanco.Text = "Cuenta Bancaria";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new System.Drawing.Point(474, 156);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new System.Drawing.Size(272, 22);
            dtpFechaNacimiento.TabIndex = 22;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Neutro", "Binario", "NS/NC" });
            cmbGenero.Location = new System.Drawing.Point(474, 217);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new System.Drawing.Size(138, 22);
            cmbGenero.TabIndex = 23;
            // 
            // registrarse
            // 
            registrarse.Location = new System.Drawing.Point(280, 323);
            registrarse.Name = "registrarse";
            registrarse.Size = new System.Drawing.Size(187, 47);
            registrarse.TabIndex = 24;
            registrarse.Text = "Registrarse";
            registrarse.UseVisualStyleBackColor = true;
            registrarse.Click += registrarse_Click;
            // 
            // menu
            // 
            menu.Location = new System.Drawing.Point(672, -1);
            menu.Name = "menu";
            menu.Size = new System.Drawing.Size(105, 47);
            menu.TabIndex = 25;
            menu.Text = "Menú";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateBlue;
            ClientSize = new System.Drawing.Size(778, 411);
            Controls.Add(menu);
            Controls.Add(registrarse);
            Controls.Add(cmbGenero);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(CuentaBanco);
            Controls.Add(GeneroCliente);
            Controls.Add(FechanacimientoCliente);
            Controls.Add(DireccionCliente);
            Controls.Add(RepeatPassword);
            Controls.Add(PasswordCliente);
            Controls.Add(EmailCliente);
            Controls.Add(UsernameCliente);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtRepetirPassword);
            Controls.Add(txtDireccion);
            Controls.Add(txtCuentaBanco);
            Controls.Add(txtUsername);
            Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtCuentaBanco;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRepetirPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label UsernameCliente;
        private System.Windows.Forms.Label EmailCliente;
        private System.Windows.Forms.Label PasswordCliente;
        private System.Windows.Forms.Label RepeatPassword;
        private System.Windows.Forms.Label DireccionCliente;
        private System.Windows.Forms.Label FechanacimientoCliente;
        private System.Windows.Forms.Label GeneroCliente;
        private System.Windows.Forms.Label CuentaBanco;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button registrarse;
        private System.Windows.Forms.Button menu;
    }
}