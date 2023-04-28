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
    public partial class CursosAdmin : Form
    {
        public CursosAdmin()
        {
            InitializeComponent();
        }

        public void CargarCursos()
        {
            using (var contexto = new GentefitDatabaseContext())
            {
                var cursos = from actividad in contexto.Actividads
                             join especialidad in contexto.Especialidads on actividad.IdEspecialidad equals especialidad.IdEspecialidad
                             join horario in contexto.Horarios on actividad.IdHorario equals horario.IdHorario
                             join monitor in contexto.Monitors on actividad.IdMonitor equals monitor.IdMonitor
                             join sala in contexto.Salas on actividad.IdSala equals sala.IdSala
                             select new
                             {
                                 IdActividad = actividad.IdActividad,
                                 NombreActividad = actividad.NombreActividad,
                                 NombreEspecialidad = especialidad.NombreEspecialidad,
                                 Dia = horario.Dia,
                                 HoraInicio = horario.HoraInicio,
                                 HoraFin = horario.HoraFin,
                                 NombreMonitor = monitor.NombreMonitor,
                                 NombreSala = sala.NombreSala
                             };

                cursos.DataSource = cursos.ToList();
                cursos.DisplayMember = "NombreActividad";
                cursos.ValueMember = "IdActividad";
            }
        }


        private void cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            MenuAdministrador menuAdministrador = new MenuAdministrador();

            this.Hide();

            menuAdministrador.Show();
        }

        private void addCurso_Click(object sender, EventArgs e)
        {
            ModificarAdmin modificarAdmin = new ModificarAdmin();

            this.Hide();

            modificarAdmin.Show();
        }
    }
}
