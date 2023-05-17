using DotNet_GenteFit.CapaDatos.Entidades;
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
        private readonly Cliente _cliente;

        public MenuCliente(Cliente cliente) : this()
        {
            _cliente = cliente;
        }

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
            var list = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                list.Add(form);
            }
            list.ForEach(n => {
                if (n is Home) 
                    n.Show();
                else 
                    n.Close(); 
            });
            
        }

        private void listAllCursos_Click(object sender, EventArgs e)
        {
            CursosCliente cursosCliente = new CursosCliente(_cliente);

            this.Hide();

            cursosCliente.Show();
        }

        private void listMyCursos_Click(object sender, EventArgs e)
        {
            MisCursos misCursos = new MisCursos(_cliente);

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
