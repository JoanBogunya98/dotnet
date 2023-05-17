using DotNet_GenteFit.CapaDatos;
using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.CapaDatos.Infraestructura;
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
    public partial class CursosCliente : Form
    {
        private readonly CursosDatos _cursosDatos;
        private readonly Cliente _cliente;

        public CursosCliente(Cliente cliente) : this()
        {
            _cliente = cliente;
        }
        public CursosCliente()
        {
            InitializeComponent();
            _cursosDatos = new CursosDatos();
            CargarCursos();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente(_cliente);

            this.Hide();

            menuCliente.Show();
        }

        public void CargarCursos()
        {
            cursos.DataSource = _cursosDatos.ObtenerCursos();
        }

        private void cmdSuscribirse_Click(object sender, EventArgs e)
        {
            var curso = cursos.SelectedItem as InformacionCurso;
            if (curso == null)
            {
                MessageBox.Show("Tiene que seleccionar un curso para subscribirse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _cursosDatos.SubscribirUsuario(_cliente, curso);
            MessageBox.Show("Subscripcion realizada!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
