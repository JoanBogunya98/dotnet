using DotNet_GenteFit.CapaDatos;
using DotNet_GenteFit.CapaDatos.Entidades;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class MisCursos : Form
    {
        private readonly CursosDatos _curso;
        private readonly Cliente _cliente;
        public MisCursos(Cliente cliente) : this()
        {
            _cliente = cliente;
            CargarCursos();
        }
        public MisCursos()
        {
            InitializeComponent();
            _curso = new CursosDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente();

            this.Hide();

            menuCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        public void CargarCursos()
        {
            listBox1.DataSource = _curso.ObtenerCursosCliente(_cliente.IdCliente);
        }
    }
}
