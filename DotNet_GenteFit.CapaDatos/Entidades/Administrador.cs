using System;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Entidades;

public partial class Administrador
{
    public int IdAdmin { get; set; }

    public string EmailAdmin { get; set; } = null!;

    public string UsernameAdmin { get; set; } = null!;

    public string PasswordAdmin { get; set; } = null!;
}
