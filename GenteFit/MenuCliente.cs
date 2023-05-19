using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.Servicios;
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
        private readonly ServicioNavegacion _navegacion;

        public MenuCliente(Cliente cliente) : this()
        {
            _cliente = cliente;
        }

        public MenuCliente()
        {
            this._navegacion = new ServicioNavegacion();
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
            _navegacion.Logout();
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
