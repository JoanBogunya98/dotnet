﻿using DotNet_GenteFit.CapaDatos;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet_GenteFit
{
    public partial class MisCursos : Form
    {
        private readonly CursosDatos _curso;

        public MisCursos()
        {
            InitializeComponent();
            _curso = new CursosDatos();
        }

        private void MisCursos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente();

            this.Hide();

            menuCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        public void CargarCursos()
        {
            // Falta conseguir el idCliente para pasarlo como argumento a la funcion ObetnerCursosCliente
            int idCliente = 0;
            listBox1.DataSource = _curso.ObtenerCursosCliente(idCliente);
            listBox1.DisplayMember = "NombreActividad";
            listBox1.ValueMember = "IdActividad";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCursos();
        }
    }
}
