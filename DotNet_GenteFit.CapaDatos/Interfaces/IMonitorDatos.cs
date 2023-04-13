using DotNet_GenteFit.CapaDatos.Entidades;
using System.Collections.Generic;

namespace DotNet_GenteFit.CapaDatos.Interfaces
{
    internal interface IMonitorDatos
    {
        void ActualizarMonitor(Monitor profesor);
        void BorrarMonitor(int idMonitor);
        void CrearMonitor(Monitor profesor);
        List<Monitor> LeerMonitores();
    }
}
