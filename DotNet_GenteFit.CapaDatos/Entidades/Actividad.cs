using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Actividad
{
    public int IdActividad { get; set; }

    public string NombreActividad { get; set; }

    public virtual ICollection<Horario> Horarios { get; } = new List<Horario>();

    public override string ToString()
    {
        return $"{NombreActividad}";
    }
}
