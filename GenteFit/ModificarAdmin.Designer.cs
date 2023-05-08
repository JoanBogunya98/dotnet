namespace DotNet_GenteFit
{
    partial class ModificarAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarAdmin));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            logout = new System.Windows.Forms.Button();
            menu = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(912, 47);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // logout
            // 
            logout.Location = new System.Drawing.Point(798, 1);
            logout.Name = "logout";
            logout.Size = new System.Drawing.Size(115, 47);
            logout.TabIndex = 1;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // menu
            // 
            menu.Location = new System.Drawing.Point(675, 1);
            menu.Name = "menu";
            menu.Size = new System.Drawing.Size(115, 47);
            menu.TabIndex = 2;
            menu.Text = "Menú";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(114, 47);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(191, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(114, 26);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(191, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(114, 26);
            textBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(353, 244);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(115, 47);
            button3.TabIndex = 6;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 111);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 18);
            label1.TabIndex = 7;
            label1.Text = "Nuevo nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 160);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 18);
            label2.TabIndex = 8;
            label2.Text = "Nueva contraseña";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(621, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(125, 26);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(396, 164);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(219, 18);
            label3.TabIndex = 10;
            label3.Text = "Repetir nueva contraseña";
            // 
            // ModificarAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateBlue;
            ClientSize = new System.Drawing.Size(914, 420);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(menu);
            Controls.Add(logout);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ModificarAdmin";
            Text = "ModificarAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}