using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Especialidad
{
    public int IdEspecialidad { get; set; }

    public string NombreEspecialidad { get; set; } = null!;

    public virtual ICollection<Profesor> Profesors { get; } = new List<Profesor>();
}
