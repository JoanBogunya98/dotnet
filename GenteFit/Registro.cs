using DotNet_GenteFit.CapaDatos;
using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.CapaDatos.Infraestructura;
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
    public partial class Registro : Form
    {
        private ClientesDatos _clientes;

        public Registro()
        {
            InitializeComponent();
            _clientes = new ClientesDatos();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registrarse_Click(object sender, EventArgs e)
        {

            string direccion = txtDireccion.Text;
            string genero = cmbGenero.SelectedItem.ToString();
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string cuentaBanco = txtCuentaBanco.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string repetirPassword = txtRepetirPassword.Text;

            if (string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("El campo de dirección no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(cuentaBanco))
            {
                MessageBox.Show("El campo de cuenta de banco no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                MessageBox.Show("El campo de correo electrónico no puede estar vacío y debe ser una dirección de correo válida");
                return;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("El campo de nombre de usuario no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password != repetirPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            // Crear una instancia de la entidad Cliente y asignarle los valores de los campos de texto
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.DireccionCliente = direccion;
            nuevoCliente.GeneroCliente = genero;
            nuevoCliente.FechanacimientoCliente = fechaNacimiento;
            nuevoCliente.FechaAlta = DateTime.Now;
            nuevoCliente.CuentaBanco = cuentaBanco;
            nuevoCliente.EmailCliente = email;
            nuevoCliente.UsernameCliente = username;
            nuevoCliente.NombreCliente = username;
            nuevoCliente.PasswordCliente = password;



            _clientes.NuevoCliente(nuevoCliente);


            MessageBox.Show("El cliente se ha registrado correctamente");
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            this.Hide();

            home.Show();
        }
    }
}
