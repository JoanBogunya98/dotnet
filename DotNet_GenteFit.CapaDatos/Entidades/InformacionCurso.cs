using System;

namespace DotNet_GenteFit.CapaDatos
{
    public record InformacionCurso(
        int IdActividad, 
        string NombreActividad, 
        string NombreEspecialidad,
        int IdHorario,
        DateTime Dia, 
        TimeSpan HoraInicio,
        TimeSpan HoraFin, 
        string NombreMonitor, 
        string NombreSala)
    {
        public override string ToString() => $"{Dia:d} - {HoraInicio:g} a {HoraFin:g} - {NombreMonitor} - {NombreSala}";
    }
}