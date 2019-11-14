using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Estudiante : Persona
    {
        public ICollection<EstudianteProyecto> EstudianteProyectos { get; set; }

        public Estudiante()
        {
        }
    }
}