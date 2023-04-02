using DotNet_GenteFit.CapaDatos.Entidades;

namespace DotNet_GenteFit.CapaDatos.Interfaces
{
    internal interface IProfesorDatos
    {
        void ActualizarProfesor(Profesor profesor);
        void BorrarProfesor(int idProfesor);
        void CrearProfesor(Profesor profesor);
        List<Profesor> LeerProfesores();
    }
}
