using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.CapaDatos.Infraestructura;
using DotNet_GenteFit.CapaDatos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_GenteFit.CapaDatos
{
    public partial class CursosDatos
    {
        private readonly IDbFactory context;

        public CursosDatos() : this(new DbFactory()) { }

        public CursosDatos(IDbFactory context)
        {
            this.context = context;
        }

        public void EliminarSubscripcion(int idReserva)
        {
            using var db = this.context.GetContext();
            db.Reservas.Where(n => n.IdReserva == idReserva).ExecuteDelete();
        }

        public List<InformacionCurso> ObtenerCursos()
        {

            using var contexto = this.context.GetContext();

            var cursos = from actividad in contexto.Actividads

                         join horario in contexto.Horarios on actividad.IdActividad equals horario.IdActividad
                         join monitor in contexto.Monitors on horario.IdMonitor equals monitor.IdMonitor
                         join especialidad in contexto.Especialidads on monitor.IdEspecialidad equals especialidad.IdEspecialidad
                         join sala in contexto.Salas on horario.IdSala equals sala.IdSala
                         select new InformacionCurso(actividad.IdActividad, actividad.NombreActividad, especialidad.NombreEspecialidad, horario.IdHorario, horario.Dia, horario.HoraInicio, horario.HoraFin, monitor.NombreMonitor, sala.NombreSala, -1);
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
                         select new InformacionCurso(actividad.IdActividad, actividad.NombreActividad, especialidad.NombreEspecialidad, horario.IdHorario, horario.Dia, horario.HoraInicio, horario.HoraFin, monitor.NombreMonitor, sala.NombreSala, reserva.IdReserva);

            return cursos.ToList();
        }

        public void SubscribirUsuario(Cliente cliente, InformacionCurso curso)
        {
            var reserva = new Reserva
            {
                Estado = (int)EstadoReserva.Activa,
                OrdenInscripcion = 0,
                IdCliente = cliente.IdCliente,
                IdHorario = curso.IdHorario
            };
            using var db = this.context.GetContext();
            db.Reservas.Add(reserva);
            db.SaveChanges();
        }

        public Horario GetHorario(int idHorario)
        {
            using var db = this.context.GetContext();
            return db.Horarios.FirstOrDefault(n => n.IdHorario == idHorario);
        }

        public void GuardaHorario(Horario horario)
        {
            using var db = this.context.GetContext();
            if (horario.IdHorario < 0)
            {
                db.Horarios.Add(horario);
            }
            else
            {
                db.Horarios.Update(horario);
            }
            db.SaveChanges();
        }

        public void EliminarHorario(int idHorario)
        {
            using var db = this.context.GetContext();
            db.Horarios.Where(n => n.IdHorario == idHorario).ExecuteDelete();
        }
    }

}