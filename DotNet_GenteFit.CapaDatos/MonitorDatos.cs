using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.CapaDatos.Infraestructura;
using DotNet_GenteFit.CapaDatos.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DotNet_GenteFit.CapaDatos
{
    public class MonitorDatos : IMonitorDatos
    {
        private readonly IDbFactory context;

        public MonitorDatos() : this(new DbFactory()) { }

        public MonitorDatos(IDbFactory context)
        {
            this.context = context;
        }

        public List<Monitor> LeerMonitores()
        {
            using var db = context.GetContext();
            return db.Monitors.ToList();
        }
        public void ActualizarMonitor(Monitor profesor)
        {
            using var db = context.GetContext();
            db.Monitors.Update(profesor);
            db.SaveChanges();
        }
        public void CrearMonitor(Monitor profesor)
        {
            using var db = context.GetContext();
            db.Monitors.Add(profesor);
            db.SaveChanges();
        }

        public void BorrarMonitor(int idMonitor)
        {
            using var db = context.GetContext();
            db.Monitors.Remove(new Monitor { IdMonitor = idMonitor });
            db.SaveChanges();
        }
    }
}
