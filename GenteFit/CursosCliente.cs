using DotNet_GenteFit.CapaDatos;
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
    public partial class CursosCliente : Form
    {
        private readonly CursosDatos _curso;

        public CursosCliente()
        {
            InitializeComponent();
            _curso = new CursosDatos();

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
            MenuCliente menuCliente = new MenuCliente();

            this.Hide();

            menuCliente.Show();
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
    }
}
