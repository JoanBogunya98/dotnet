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
            pictureBox1.Size = new System.Drawing.Size(685, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(252, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(252, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // login
            // 
            login.Location = new System.Drawing.Point(252, 178);
            login.Name = "login";
            login.Size = new System.Drawing.Size(100, 23);
            login.TabIndex = 3;
            login.Text = "Iniciar sesión";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // registrarse
            // 
            registrarse.Location = new System.Drawing.Point(252, 223);
            registrarse.Name = "registrarse";
            registrarse.Size = new System.Drawing.Size(100, 23);
            registrarse.TabIndex = 4;
            registrarse.Text = "registrarse";
            registrarse.UseVisualStyleBackColor = true;
            registrarse.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(100, 50);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(684, 375);
            Controls.Add(pictureBox2);
            Controls.Add(registrarse);
            Controls.Add(login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Home";
            Text = "FormInicio";
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