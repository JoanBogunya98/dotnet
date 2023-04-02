using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string NombreCliente { get; set; } = null!;

    public string DireccionCliente { get; set; } = null!;

    public string GeneroCliente { get; set; } = null!;

    public DateTime FechanacimientoCliente { get; set; }

    public DateTime FechaAlta { get; set; }

    public string CuentaBanco { get; set; } = null!;

    public string EmailCliente { get; set; } = null!;

    public string UsernameCliente { get; set; } = null!;

    public string PasswordCliente { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; } = new List<Reserva>();
}
