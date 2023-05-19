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
            cmdGuardar = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            IdActividad = new System.Windows.Forms.Label();
            NombreActividad = new System.Windows.Forms.Label();
            NombreEspecialidad = new System.Windows.Forms.Label();
            IdHorario = new System.Windows.Forms.Label();
            Dia = new System.Windows.Forms.Label();
            HoraInicio = new System.Windows.Forms.Label();
            HoraFin = new System.Windows.Forms.Label();
            NombreSala = new System.Windows.Forms.Label();
            txtIdHorario = new System.Windows.Forms.TextBox();
            txtCapacidadMaxima = new System.Windows.Forms.TextBox();
            dtDia = new System.Windows.Forms.DateTimePicker();
            cboMonitores = new System.Windows.Forms.ComboBox();
            cboActividades = new System.Windows.Forms.ComboBox();
            cboSalas = new System.Windows.Forms.ComboBox();
            dtHoraInicio = new System.Windows.Forms.DateTimePicker();
            dtHoraFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // cmdGuardar
            // 
            cmdGuardar.Location = new System.Drawing.Point(427, 293);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new System.Drawing.Size(115, 47);
            cmdGuardar.TabIndex = 9;
            cmdGuardar.Text = "Guardar";
            cmdGuardar.UseVisualStyleBackColor = true;
            cmdGuardar.Click += cmdGuardar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logojpg;
            pictureBox3.Location = new System.Drawing.Point(19, 76);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(96, 102);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // IdActividad
            // 
            IdActividad.AutoSize = true;
            IdActividad.Location = new System.Drawing.Point(169, 101);
            IdActividad.Name = "IdActividad";
            IdActividad.Size = new System.Drawing.Size(23, 14);
            IdActividad.TabIndex = 12;
            IdActividad.Text = "ID";
            // 
            // NombreActividad
            // 
            NombreActividad.AutoSize = true;
            NombreActividad.Location = new System.Drawing.Point(169, 234);
            NombreActividad.Name = "NombreActividad";
            NombreActividad.Size = new System.Drawing.Size(130, 14);
            NombreActividad.TabIndex = 13;
            NombreActividad.Text = "Capacidad Máxima";
            // 
            // NombreEspecialidad
            // 
            NombreEspecialidad.AutoSize = true;
            NombreEspecialidad.Location = new System.Drawing.Point(169, 145);
            NombreEspecialidad.Name = "NombreEspecialidad";
            NombreEspecialidad.Size = new System.Drawing.Size(57, 14);
            NombreEspecialidad.TabIndex = 14;
            NombreEspecialidad.Text = "Monitor";
            // 
            // IdHorario
            // 
            IdHorario.AutoSize = true;
            IdHorario.Location = new System.Drawing.Point(169, 191);
            IdHorario.Name = "IdHorario";
            IdHorario.Size = new System.Drawing.Size(68, 14);
            IdHorario.TabIndex = 15;
            IdHorario.Text = "Actividad";
            // 
            // Dia
            // 
            Dia.AutoSize = true;
            Dia.Location = new System.Drawing.Point(554, 106);
            Dia.Name = "Dia";
            Dia.Size = new System.Drawing.Size(29, 14);
            Dia.TabIndex = 16;
            Dia.Text = "Dia";
            // 
            // HoraInicio
            // 
            HoraInicio.AutoSize = true;
            HoraInicio.Location = new System.Drawing.Point(554, 146);
            HoraInicio.Name = "HoraInicio";
            HoraInicio.Size = new System.Drawing.Size(78, 14);
            HoraInicio.TabIndex = 17;
            HoraInicio.Text = "Hora inicio";
            // 
            // HoraFin
            // 
            HoraFin.AutoSize = true;
            HoraFin.Location = new System.Drawing.Point(554, 191);
            HoraFin.Name = "HoraFin";
            HoraFin.Size = new System.Drawing.Size(60, 14);
            HoraFin.TabIndex = 18;
            HoraFin.Text = "Hora fin";
            // 
            // NombreSala
            // 
            NombreSala.AutoSize = true;
            NombreSala.Location = new System.Drawing.Point(554, 234);
            NombreSala.Name = "NombreSala";
            NombreSala.Size = new System.Drawing.Size(36, 14);
            NombreSala.TabIndex = 20;
            NombreSala.Text = "Sala";
            // 
            // txtIdHorario
            // 
            txtIdHorario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            txtIdHorario.Location = new System.Drawing.Point(317, 98);
            txtIdHorario.Name = "txtIdHorario";
            txtIdHorario.ReadOnly = true;
            txtIdHorario.Size = new System.Drawing.Size(100, 22);
            txtIdHorario.TabIndex = 0;
            // 
            // txtCapacidadMaxima
            // 
            txtCapacidadMaxima.Location = new System.Drawing.Point(317, 230);
            txtCapacidadMaxima.Name = "txtCapacidadMaxima";
            txtCapacidadMaxima.Size = new System.Drawing.Size(100, 22);
            txtCapacidadMaxima.TabIndex = 1;
            // 
            // dtDia
            // 
            dtDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtDia.Location = new System.Drawing.Point(659, 100);
            dtDia.Name = "dtDia";
            dtDia.Size = new System.Drawing.Size(142, 22);
            dtDia.TabIndex = 4;
            // 
            // cboMonitores
            // 
            cboMonitores.FormattingEnabled = true;
            cboMonitores.Location = new System.Drawing.Point(317, 142);
            cboMonitores.Name = "cboMonitores";
            cboMonitores.Size = new System.Drawing.Size(220, 22);
            cboMonitores.TabIndex = 21;
            // 
            // cboActividades
            // 
            cboActividades.FormattingEnabled = true;
            cboActividades.Location = new System.Drawing.Point(317, 183);
            cboActividades.Name = "cboActividades";
            cboActividades.Size = new System.Drawing.Size(220, 22);
            cboActividades.TabIndex = 22;
            // 
            // cboSalas
            // 
            cboSalas.FormattingEnabled = true;
            cboSalas.Location = new System.Drawing.Point(659, 230);
            cboSalas.Name = "cboSalas";
            cboSalas.Size = new System.Drawing.Size(142, 22);
            cboSalas.TabIndex = 23;
            // 
            // dtHoraInicio
            // 
            dtHoraInicio.CustomFormat = "HH:mm";
            dtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtHoraInicio.Location = new System.Drawing.Point(659, 140);
            dtHoraInicio.Name = "dtHoraInicio";
            dtHoraInicio.ShowUpDown = true;
            dtHoraInicio.Size = new System.Drawing.Size(100, 22);
            dtHoraInicio.TabIndex = 24;
            dtHoraInicio.Value = new System.DateTime(2023, 5, 19, 13, 54, 0, 0);
            // 
            // dtHoraFin
            // 
            dtHoraFin.CustomFormat = "HH:mm";
            dtHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtHoraFin.Location = new System.Drawing.Point(659, 183);
            dtHoraFin.Name = "dtHoraFin";
            dtHoraFin.ShowUpDown = true;
            dtHoraFin.Size = new System.Drawing.Size(100, 22);
            dtHoraFin.TabIndex = 25;
            dtHoraFin.Value = new System.DateTime(2023, 5, 19, 13, 5, 0, 0);
            // 
            // ModificarAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateBlue;
            ClientSize = new System.Drawing.Size(914, 362);
            Controls.Add(dtHoraFin);
            Controls.Add(dtHoraInicio);
            Controls.Add(cboSalas);
            Controls.Add(cboActividades);
            Controls.Add(cboMonitores);
            Controls.Add(dtDia);
            Controls.Add(txtCapacidadMaxima);
            Controls.Add(txtIdHorario);
            Controls.Add(NombreSala);
            Controls.Add(HoraFin);
            Controls.Add(HoraInicio);
            Controls.Add(Dia);
            Controls.Add(IdHorario);
            Controls.Add(NombreEspecialidad);
            Controls.Add(NombreActividad);
            Controls.Add(IdActividad);
            Controls.Add(pictureBox3);
            Controls.Add(cmdGuardar);
            Controls.Add(pictureBox2);
            Controls.Add(menu);
            Controls.Add(logout);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ModificarAdmin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ModificarAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label IdActividad;
        private System.Windows.Forms.Label NombreActividad;
        private System.Windows.Forms.Label NombreEspecialidad;
        private System.Windows.Forms.Label IdHorario;
        private System.Windows.Forms.Label Dia;
        private System.Windows.Forms.Label HoraInicio;
        private System.Windows.Forms.Label HoraFin;
        private System.Windows.Forms.Label NombreSala;
        private System.Windows.Forms.TextBox txtIdHorario;
        private System.Windows.Forms.TextBox txtCapacidadMaxima;
        private System.Windows.Forms.DateTimePicker dtDia;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.ComboBox cboMonitores;
        private System.Windows.Forms.ComboBox cboActividades;
        private System.Windows.Forms.ComboBox cboSalas;
        private System.Windows.Forms.DateTimePicker dtHoraInicio;
        private System.Windows.Forms.DateTimePicker dtHoraFin;
    }
}