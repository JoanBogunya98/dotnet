using Microsoft.EntityFrameworkCore;

namespace DotNet_GenteFit.CapaDatos.Infraestructura
{
    public partial class GentefitDatabaseContext : DbContext
    {
        private readonly string connectionString;

        public GentefitDatabaseContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseSqlServer(connectionString);

    }
}