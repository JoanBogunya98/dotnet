namespace DotNet_GenteFit
{
    partial class MisCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisCursos));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            listBox1 = new System.Windows.Forms.ListBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(913, 47);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(800, 1);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(113, 47);
            button1.TabIndex = 1;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(680, 1);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(113, 47);
            button2.TabIndex = 2;
            button2.Text = "Menú";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(114, 47);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Location = new System.Drawing.Point(139, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(738, 312);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logojpg;
            pictureBox3.Location = new System.Drawing.Point(18, 66);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(96, 102);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // MisCursos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateBlue;
            ClientSize = new System.Drawing.Size(914, 420);
            Controls.Add(pictureBox3);
            Controls.Add(listBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MisCursos";
            Text = "MisCursos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}