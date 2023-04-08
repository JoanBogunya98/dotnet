using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.CapaDatos.Infraestructura;
using DotNet_GenteFit.CapaDatos.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DotNet_GenteFit.CapaDatos
{
    public class ActividadDatos : IActividadDatos
    {
        private readonly IDbFactory context;

        public ActividadDatos() : this(new DbFactory()) { }

        public ActividadDatos(IDbFactory context)
        {
            this.context = context;
        }

        public List<Actividad> LeerActividades()
        {
            using var db = context.GetContext();
            return db.Actividads.ToList();
        }
    }
}
