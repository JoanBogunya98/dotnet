using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Profesor
{
    public int IdProfesor { get; set; }

    public string NombreProfesor { get; set; } = null!;

    public int IdEspecialidad { get; set; }

    public virtual ICollection<Curso> Cursos { get; } = new List<Curso>();

    public virtual Especialidad IdEspecialidadNavigation { get; set; } = null!;
}
