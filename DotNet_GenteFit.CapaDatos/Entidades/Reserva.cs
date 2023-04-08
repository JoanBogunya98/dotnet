using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public int IdHorario { get; set; }

    public int IdCliente { get; set; }

    public int Estado { get; set; }

    public int OrdenInscripcion { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; }

    public virtual Horario IdHorarioNavigation { get; set; }
}
