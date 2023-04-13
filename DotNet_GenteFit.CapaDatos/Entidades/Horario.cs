using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Horario
{
    public int IdHorario { get; set; }

    public DateTime Dia { get; set; }

    public TimeSpan HoraInicio { get; set; }

    public TimeSpan HoraFin { get; set; }

    public int IdActividad { get; set; }

    public int IdMonitor { get; set; }

    public int IdSala { get; set; }

    public int CapacidadMaxima { get; set; }

    public virtual Actividad IdActividadNavigation { get; set; }

    public virtual Monitor IdMonitorNavigation { get; set; }

    public virtual Sala IdSalaNavigation { get; set; }

    public virtual ICollection<Reserva> Reservas { get; } = new List<Reserva>();
}
