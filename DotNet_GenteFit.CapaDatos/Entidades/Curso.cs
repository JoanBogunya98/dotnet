using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Curso
{
    public int IdCurso { get; set; }

    public string NombreCurso { get; set; } = null!;

    public int IdProfesor { get; set; }

    public int IdAula { get; set; }

    public int IdDia { get; set; }

    public int IdHora { get; set; }

    public virtual Aula IdAulaNavigation { get; set; } = null!;

    public virtual Dium IdDiaNavigation { get; set; } = null!;

    public virtual Hora IdHoraNavigation { get; set; } = null!;

    public virtual Profesor IdProfesorNavigation { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; } = new List<Reserva>();
}
