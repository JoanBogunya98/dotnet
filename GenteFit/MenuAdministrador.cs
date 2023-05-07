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
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
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
