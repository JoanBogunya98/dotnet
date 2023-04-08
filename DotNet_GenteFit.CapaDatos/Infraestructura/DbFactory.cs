using DotNet_GenteFit.CapaDatos.Interfaces;

namespace DotNet_GenteFit.CapaDatos.Infraestructura
{
    internal class DbFactory : IDbFactory
    {
        private string connectionString;

        public DbFactory()
        {
            this.connectionString = "Data Source=(local);Initial Catalog=GentefitDatabase;Integrated Security=True;Trust Server Certificate=true";
        }
        public GentefitDatabaseContext GetContext() { return new GentefitDatabaseContext(connectionString); }
    }
}