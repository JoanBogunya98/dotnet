namespace DotNet_GenteFit
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            login = new System.Windows.Forms.Button();
            registrarse = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(783, 47);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Location = new System.Drawing.Point(288, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(114, 15);
            textBox1.TabIndex = 1;
            textBox1.Text = "GenteFit";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.Color.DarkSlateBlue;
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Location = new System.Drawing.Point(239, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(220, 15);
            textBox2.TabIndex = 2;
            textBox2.Text = "\r\n¡La app de tu gimnasio!\r\n";
            textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // login
            // 
            login.BackColor = System.Drawing.Color.LavenderBlush;
            login.Location = new System.Drawing.Point(288, 160);
            login.Name = "login";
            login.Size = new System.Drawing.Size(124, 33);
            login.TabIndex = 3;
            login.Text = "Iniciar sesión";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // registrarse
            // 
            registrarse.Location = new System.Drawing.Point(288, 208);
            registrarse.Name = "registrarse";
            registrarse.Size = new System.Drawing.Size(124, 33);
            registrarse.TabIndex = 4;
            registrarse.Text = "Registrarse";
            registrarse.UseVisualStyleBackColor = true;
            registrarse.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logojpg;
            pictureBox2.Location = new System.Drawing.Point(27, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(96, 102);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateBlue;
            ClientSize = new System.Drawing.Size(700, 442);
            Controls.Add(pictureBox2);
            Controls.Add(registrarse);
            Controls.Add(login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Home";
            Load += FormInicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button registrarse;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}