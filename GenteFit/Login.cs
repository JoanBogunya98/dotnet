using DotNet_GenteFit.CapaDatos;
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
        private ClientesDatos _clientes;
        private AdministradorDatos _admins;

        public Login()
        {
            InitializeComponent();
            _clientes = new ClientesDatos();
            _admins = new AdministradorDatos("recursos/administradores.xml");

        }

        private void login_Click(object sender, EventArgs e)
        {

            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;



            Cliente cliente = _clientes.BuscaCliente(usuario, contraseña);

            Administrador admin = _admins.BuscarAdmin(usuario, contraseña);

            if (cliente != null)
            {
                MenuCliente MenuCliente = new MenuCliente(cliente);

                this.Hide();

                MenuCliente.Show();
            }

            else if (admin != null)
            {

                var cursosAdmin = new CursosAdmin(admin);

                this.Hide();

                cursosAdmin.Show();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas. Intente nuevamente.");
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

