﻿using DotNet_GenteFit.CapaDatos;
using DotNet_GenteFit.CapaDatos.Infraestructura;
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
    public partial class CursosAdmin : Form
    {
        private readonly CursosDatos _curso;


        public CursosAdmin()
        {
            InitializeComponent();
            _curso = new CursosDatos();

        }

        public void CargarCursos()
        {

            cursos.DataSource = _curso.ObtenerCursos();
            cursos.DisplayMember = "NombreActividad";
            cursos.ValueMember = "IdActividad";

        }


        private void cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCursos();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            CursosAdmin CursosAdmin = new CursosAdmin();

            this.Hide();

            CursosAdmin.Show();
        }

        private void addCurso_Click(object sender, EventArgs e)
        {
            InsertarAdmin insertarAdmin = new InsertarAdmin();

            this.Hide();

            insertarAdmin.Show();
        }

        private void modificarCurso_Click(object sender, EventArgs e)
        {
            ModificarAdmin modificarAdmin = new ModificarAdmin();

            this.Hide();

            modificarAdmin.Show();
        }

        /*private void eliminarCurso_Click(object sender, EventArgs e)
        {
            ModificarAdmin eliminarAdmin = new EliminarAdmin();

            this.Hide();

            eliminarAdmin.Show();
        }*/

    }

}
