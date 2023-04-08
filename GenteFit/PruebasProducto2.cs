using DotNet_GenteFit.CapaDatos;
using DotNet_GenteFit.CapaDatos.Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DotNet_GenteFit
{
    public partial class PruebasProducto2 : Form
    {
        private readonly MonitorDatos monitores;
        private readonly SalasDatos salas;
        private readonly ActividadDatos actividades;
        private readonly AdministradorDatos administradores;

        public PruebasProducto2()
        {
            InitializeComponent();
            monitores = new MonitorDatos();
            salas = new SalasDatos();
            actividades = new ActividadDatos();
            administradores = new AdministradorDatos("recursos/administradores.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = monitores.LeerMonitores();
            txtDebug.Text = string.Join(Environment.NewLine, lista.Select(n => $"{n.IdMonitor} - {n.NombreMonitor}"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var profesor = new Monitor
            {
                IdEspecialidad = 1,
                NombreMonitor = $"Arnold S {DateTime.Now.Ticks}"
            };
            monitores.CrearMonitor(profesor);
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBorrar.Text, out var res))
            {
                monitores.BorrarMonitor(res);
            }
            else
            {
                MessageBox.Show("El id no es numérico");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var lista = administradores.LeerAdministradores();
            txtDebug.Text = string.Join(Environment.NewLine, lista.Select(n => $"{n.IdAdmin} - {n.UsernameAdmin}"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var lista = salas.LeerSalas();
            txtDebug.Text = string.Join(Environment.NewLine, lista.Select(n => $"{n.IdSala} - {n.NombreSala}"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var lista = actividades.LeerActividades();
            txtDebug.Text = string.Join(Environment.NewLine, lista.Select(n => $"{n.IdActividad} - {n.NombreActividad}"));
        }
    }
}