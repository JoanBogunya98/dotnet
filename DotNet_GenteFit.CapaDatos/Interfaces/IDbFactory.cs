using DotNet_GenteFit.CapaDatos.Infraestructura;

namespace DotNet_GenteFit.CapaDatos.Interfaces
{
    public interface IDbFactory
    {
        GentefitDatabaseContext GetContext();
    }
}