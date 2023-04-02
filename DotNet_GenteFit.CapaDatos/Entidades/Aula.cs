using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Aula
{
    public int IdAula { get; set; }

    public int NumeroAula { get; set; }

    public virtual ICollection<Curso> Cursos { get; } = new List<Curso>();
}
