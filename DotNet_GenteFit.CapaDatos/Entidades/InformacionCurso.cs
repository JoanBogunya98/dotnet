using System;

namespace DotNet_GenteFit.CapaDatos
{
    public class InformacionCurso
    {
        public int IdActividad { get; set; }
        public string NombreActividad { get; set; }
        public string NombreEspecialidad { get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string NombreMonitor { get; set; }
        public string NombreSala { get; set; }
    }
}