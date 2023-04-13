using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Especialidad
{
    public int IdEspecialidad { get; set; }

    public string NombreEspecialidad { get; set; }

    public virtual ICollection<Monitor> Monitors { get; } = new List<Monitor>();
}
