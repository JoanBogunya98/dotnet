using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Dium
{
    public int IdDia { get; set; }

    public DateTime Fecha { get; set; }

    public virtual ICollection<Curso> Cursos { get; } = new List<Curso>();
}
