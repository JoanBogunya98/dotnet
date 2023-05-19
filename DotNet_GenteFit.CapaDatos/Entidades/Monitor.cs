using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Monitor
{
    public int IdMonitor { get; set; }

    public string NombreMonitor { get; set; }

    public int IdEspecialidad { get; set; }

    public virtual ICollection<Horario> Horarios { get; } = new List<Horario>();

    public virtual Especialidad IdEspecialidadNavigation { get; set; }

    public override string ToString()
    {
        return $"{NombreMonitor} - {IdEspecialidadNavigation?.NombreEspecialidad}";
    }
}
