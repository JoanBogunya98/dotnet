using DotNet_GenteFit.CapaDatos.Interfaces;

namespace DotNet_GenteFit.CapaDatos.Infraestructura
{
    internal class DbFactory : IDbFactory
    {
        public GentefitDatabaseContext GetContext() { return new GentefitDatabaseContext(); }
    }
}