using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public int IdCurso { get; set; }

    public int IdCliente { get; set; }

    public int Estado { get; set; }

    public int NumeroEspera { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Curso IdCursoNavigation { get; set; } = null!;
}
