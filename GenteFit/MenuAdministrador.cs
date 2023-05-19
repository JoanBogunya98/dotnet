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
    public partial class MenuAdministrador : Form
    {
        private readonly ServicioNavegacion _navegacion;

        public MenuAdministrador()
        {
            InitializeComponent();
            this._navegacion = new ServicioNavegacion();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            _navegacion.Logout();
        }

        private void listAllCursos_Click(object sender, EventArgs e)
        {
            CursosAdmin cursosAdmin = new CursosAdmin();

            this.Hide();

            cursosAdmin.Show();
        }

        private void listAllClientes_Click(object sender, EventArgs e)
        {
            TodosClientes todosClientes = new TodosClientes();

            this.Hide();

            todosClientes.Show();
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
