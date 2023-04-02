using DotNet_GenteFit.CapaDatos.Entidades;
using DotNet_GenteFit.CapaDatos.Infraestructura;
using DotNet_GenteFit.CapaDatos.Interfaces;

namespace DotNet_GenteFit.CapaDatos
{
    public class ProfesorDatos : IProfesorDatos
    {
        private readonly IDbFactory context;

        public ProfesorDatos() : this(new DbFactory()) { }

        public ProfesorDatos(IDbFactory context)
        {
            this.context = context;
        }

        public List<Profesor> LeerProfesores()
        {
            using var db = context.GetContext();
            return db.Profesors.ToList();
        }
        public void ActualizarProfesor(Profesor profesor)
        {
            using var db = context.GetContext();
            db.Profesors.Update(profesor);
            db.SaveChanges();
        }
        public void CrearProfesor(Profesor profesor)
        {
            using var db = context.GetContext();
            db.Profesors.Add(profesor);
            db.SaveChanges();
        }

        public void BorrarProfesor(int idProfesor)
        {
            using var db = context.GetContext();
            db.Profesors.Remove(new Profesor { IdProfesor = idProfesor });
            db.SaveChanges();
        }
    }
}
