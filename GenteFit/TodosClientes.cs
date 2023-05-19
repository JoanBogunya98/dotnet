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
    public partial class TodosClientes : Form
    {
        private readonly ServicioNavegacion _navegacion;

        public TodosClientes()
        {
            InitializeComponent();
            this._navegacion = new ServicioNavegacion();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdministrador menuAdministrador = new MenuAdministrador();

            this.Hide();

            menuAdministrador.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _navegacion.Logout();
        }
    }
}
