using DotNet_GenteFit.CapaDatos;
using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.Servicios;
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
        private readonly ServicioNavegacion _navegacion;
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
            this._navegacion = new ServicioNavegacion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente(_cliente);

            this.Hide();

            menuCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _navegacion.Logout();
        }

        public void CargarCursos()
        {
            listBox1.DataSource = _curso.ObtenerCursosCliente(_cliente.IdCliente);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdEliminarSubscripcion_Click(object sender, EventArgs e)
        {
            var sub = listBox1.SelectedItem as InformacionCurso;
            if (sub == null)
            {
                MessageBox.Show("Debe seleccionar una subscripción a eliminar");
            }
            else
            {
                if (MessageBox.Show("Está seguro de querer eliminar la subscripción?", "Eliminar subscripción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _curso.EliminarSubscripcion(sub.IdReserva);
                    CargarCursos();
                    MessageBox.Show("Subscripción eliminada correctamente");
                }
            }
        }
    }
}
