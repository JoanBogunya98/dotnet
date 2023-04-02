namespace DotNet_GenteFit
{
    partial class PruebasProducto2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtDebug = new TextBox();
            button2 = new Button();
            cmdBorrar = new Button();
            txtBorrar = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 36);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 0;
            button1.Text = "Listar Profesores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDebug
            // 
            txtDebug.Location = new Point(51, 124);
            txtDebug.Multiline = true;
            txtDebug.Name = "txtDebug";
            txtDebug.Size = new Size(699, 284);
            txtDebug.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(175, 38);
            button2.Name = "button2";
            button2.Size = new Size(112, 23);
            button2.TabIndex = 2;
            button2.Text = "Crear Profesor";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmdBorrar
            // 
            cmdBorrar.Location = new Point(311, 37);
            cmdBorrar.Name = "cmdBorrar";
            cmdBorrar.Size = new Size(75, 23);
            cmdBorrar.TabIndex = 3;
            cmdBorrar.Text = "Borrar";
            cmdBorrar.UseVisualStyleBackColor = true;
            cmdBorrar.Click += cmdBorrar_Click;
            // 
            // txtBorrar
            // 
            txtBorrar.Location = new Point(402, 38);
            txtBorrar.Name = "txtBorrar";
            txtBorrar.Size = new Size(100, 23);
            txtBorrar.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(51, 81);
            button3.Name = "button3";
            button3.Size = new Size(170, 23);
            button3.TabIndex = 5;
            button3.Text = "Listar Administradores";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // PruebasProducto2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 467);
            Controls.Add(button3);
            Controls.Add(txtBorrar);
            Controls.Add(cmdBorrar);
            Controls.Add(button2);
            Controls.Add(txtDebug);
            Controls.Add(button1);
            Name = "PruebasProducto2";
            Text = "Form1";
            Load += PruebasProducto2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtDebug;
        private Button button2;
        private Button cmdBorrar;
        private TextBox txtBorrar;
        private Button button3;
    }
}