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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            logout = new System.Windows.Forms.Button();
            menu = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(798, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // logout
            // 
            logout.Location = new System.Drawing.Point(698, 1);
            logout.Name = "logout";
            logout.Size = new System.Drawing.Size(101, 50);
            logout.TabIndex = 1;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // menu
            // 
            menu.Location = new System.Drawing.Point(591, 1);
            menu.Name = "menu";
            menu.Size = new System.Drawing.Size(101, 50);
            menu.TabIndex = 2;
            menu.Text = "Menú";
            menu.UseVisualStyleBackColor = true;
            menu.Click += menu_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(100, 50);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(309, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(309, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(309, 261);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(101, 50);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // ModificarAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(menu);
            Controls.Add(logout);
            Controls.Add(pictureBox1);
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
    }
}