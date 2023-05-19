using DotNet_GenteFit.CapaDatos;
using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.CapaDatos.Infraestructura;
using DotNet_GenteFit.Servicios;
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
    public partial class CursosAdmin : Form
    {
        private readonly CursosDatos _cursos;
        private readonly ServicioNavegacion _navegacion;
        private Administrador _admin;

        public CursosAdmin()
        {
            InitializeComponent();
            _cursos = new CursosDatos();
            CargarCursos();
            this._navegacion = new ServicioNavegacion();
        }

        public CursosAdmin(Administrador admin) : this()
        {
            this._admin = admin;
        }

        public void CargarCursos()
        {
            cursos.DataSource = _cursos.ObtenerCursos();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            _navegacion.Logout();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            CursosAdmin CursosAdmin = new CursosAdmin();

            this.Hide();

            CursosAdmin.Show();
        }

        private void addCurso_Click(object sender, EventArgs e)
        {
            ModificarAdmin modificarAdmin = new ModificarAdmin(_admin);

            this.Hide();

            modificarAdmin.ShowNewCurso();
        }

        private void modificarCurso_Click(object sender, EventArgs e)
        {
            ModificarAdmin modificarAdmin = new ModificarAdmin(_admin);

            this.Hide();
            var curso = cursos.SelectedItem as InformacionCurso;

            if (curso == null)
            {
                MessageBox.Show("Debe seleccionar un curso para modificar");
            }
            else
            {
                modificarAdmin.ShowCurso(curso);
            }
        }

        private void eliminarCurso_Click(object sender, EventArgs e)
        {
            var curso = cursos.SelectedItem as InformacionCurso;
            if (curso == null)
            {
                MessageBox.Show("Debe seleccionar un curso para borrarlo");
            }
            else
            {
                if (MessageBox.Show("Está seguro de querer borrar el curso?", "Borrar curso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _cursos.EliminarHorario(curso.IdHorario);
                    CargarCursos();
                    MessageBox.Show("Curso borrado correctamente");
                }
            }
        }
    }
}
