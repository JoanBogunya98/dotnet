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
    public partial class ModificacionDatos : Form
    {
        private readonly ServicioNavegacion _navegacion;

        public ModificacionDatos()
        {
            InitializeComponent();
            this._navegacion = new ServicioNavegacion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente();

            this.Hide();

            menuCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _navegacion.Logout();
        }
    }
}
