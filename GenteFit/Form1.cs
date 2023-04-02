using DotNet_GenteFit.CapaDatos;
using DotNet_GenteFit.CapaDatos.Entidades;

namespace DotNet_GenteFit
{
    public partial class Form1 : Form
    {
        private readonly ProfesorDatos profesores;

        public Form1()
        {
            InitializeComponent();
            profesores = new ProfesorDatos();
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
    }
}