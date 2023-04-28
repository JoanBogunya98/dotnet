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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        private void listAllCursos_Click(object sender, EventArgs e)
        {
            CursosCliente cursosCliente = new CursosCliente();

            this.Hide();

            cursosCliente.Show();
        }

        private void listMyCursos_Click(object sender, EventArgs e)
        {
            MisCursos misCursos = new MisCursos();

            this.Hide();

            misCursos.Show();
        }

        private void ModificarDatos_Click(object sender, EventArgs e)
        {
            ModificacionDatos modificacionDatos = new ModificacionDatos();

            this.Hide();

            modificacionDatos.Show();
        }
    }
}
