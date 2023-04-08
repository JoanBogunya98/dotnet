using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string NombreCliente { get; set; }

    public string DireccionCliente { get; set; }

    public string GeneroCliente { get; set; }

    public DateTime FechanacimientoCliente { get; set; }

    public DateTime FechaAlta { get; set; }

    public string CuentaBanco { get; set; }

    public string EmailCliente { get; set; }

    public string UsernameCliente { get; set; }

    public string PasswordCliente { get; set; }

    public virtual ICollection<Reserva> Reservas { get; } = new List<Reserva>();
}
