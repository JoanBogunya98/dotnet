using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.CapaDatos.Infraestructura;
using DotNet_GenteFit.CapaDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_GenteFit.CapaDatos
{
    public class CursosDatos
    {
        private readonly IDbFactory context;

        public CursosDatos() : this(new DbFactory()) { }

        public CursosDatos(IDbFactory context)
        {
            this.context = context;
        }

        public List<InformacionCurso> ObtenerCursos()
        {

            using var contexto = this.context.GetContext();

            var cursos = from actividad in contexto.Actividads

                         join horario in contexto.Horarios on actividad.IdActividad equals horario.IdActividad
                         join monitor in contexto.Monitors on horario.IdMonitor equals monitor.IdMonitor
                         join especialidad in contexto.Especialidads on monitor.IdEspecialidad equals especialidad.IdEspecialidad
                         join sala in contexto.Salas on horario.IdSala equals sala.IdSala
                         select new InformacionCurso
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
            return cursos.ToList();
        }

        public List<InformacionCurso> ObtenerCursosCliente(int idCliente)
        {
            using var contexto = this.context.GetContext();

            var cursos = from actividad in contexto.Actividads
                         join horario in contexto.Horarios on actividad.IdActividad equals horario.IdActividad
                         join monitor in contexto.Monitors on horario.IdMonitor equals monitor.IdMonitor
                         join especialidad in contexto.Especialidads on monitor.IdEspecialidad equals especialidad.IdEspecialidad
                         join sala in contexto.Salas on horario.IdSala equals sala.IdSala
                         join reserva in contexto.Reservas on horario.IdHorario equals reserva.IdHorario
                         where reserva.IdCliente == idCliente
                         select new InformacionCurso
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

            return cursos.ToList();
        }

    }

}