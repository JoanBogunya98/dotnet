using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Sala
{
    public int IdSala { get; set; }

    public string NombreSala { get; set; }

    public virtual ICollection<Horario> Horarios { get; } = new List<Horario>();
}
