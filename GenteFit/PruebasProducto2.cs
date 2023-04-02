using DotNet_GenteFit.CapaDatos;
using DotNet_GenteFit.CapaDatos.Entidades;

namespace DotNet_GenteFit
{
    public partial class PruebasProducto2 : Form
    {
        private readonly ProfesorDatos profesores;
        private readonly AdministradorDatos administradores;

        public PruebasProducto2()
        {
            InitializeComponent();
            profesores = new ProfesorDatos();
            administradores = new AdministradorDatos("recursos/administradores.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = profesores.LeerProfesores();
            txtDebug.Text = string.Join(Environment.NewLine, lista.Select(n => $"{n.IdProfesor} - {n.NombreProfesor}"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var profesor = new Profesor
            {
                IdEspecialidad = 1,
                NombreProfesor = $"Arnold S {DateTime.Now.Ticks}"
            };
            profesores.CrearProfesor(profesor);
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBorrar.Text, out var res))
            {
                profesores.BorrarProfesor(res);
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

        private void PruebasProducto2_Load(object sender, EventArgs e)
        {

        }
    }
}