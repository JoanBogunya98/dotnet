using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Hora
{
    public int IdHora { get; set; }

    public TimeSpan HoraInicio { get; set; }

    public TimeSpan HoraFinal { get; set; }

    public virtual ICollection<Curso> Cursos { get; } = new List<Curso>();
}
