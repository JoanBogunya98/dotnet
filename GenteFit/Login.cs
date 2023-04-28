using DotNet_GenteFit.CapaDatos.Entidades;
using Microsoft.EntityFrameworkCore;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {

            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

            using (var context = new DBContext())
            {
                Cliente cliente = context.Clientes.FirstOrDefault(c => c.UsernameCliente == usuario && c.PasswordCliente == contraseña);

                Administrador admin = context.Administradores.FirstOrDefault(a => a.UsernameAdmin == usuario && a.PasswordAdmin == contraseña);

                if (cliente != null)
                {
                    MenuCliente MenuCliente = new MenuCliente();

                    this.Hide();

                    MenuCliente.Show();
                }

                else if (admin != null)
                {

                    MenuAdministrador MenuAdministrador = new MenuAdministrador();

                    this.Hide();

                    MenuAdministrador.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales inválidas. Intente nuevamente.");
                }
            }
        }

        private void registro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();

            this.Hide();

            registro.Show();
        }
    }
}

