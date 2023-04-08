using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.CapaDatos.Infraestructura;
using DotNet_GenteFit.CapaDatos.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DotNet_GenteFit.CapaDatos
{
    public class SalasDatos : ISalasDatos
    {
        private readonly IDbFactory context;

        public SalasDatos() : this(new DbFactory()) { }

        public SalasDatos(IDbFactory context)
        {
            this.context = context;
        }

        public List<Sala> LeerSalas()
        {
            using var db = context.GetContext();
            return db.Salas.ToList();
        }
    }
}
