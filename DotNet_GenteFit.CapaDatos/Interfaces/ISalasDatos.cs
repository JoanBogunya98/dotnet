using DotNet_GenteFit.CapaDatos.Entidades;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Interfaces
{
    public interface ISalasDatos
    {
        List<Sala> LeerSalas();
    }
}