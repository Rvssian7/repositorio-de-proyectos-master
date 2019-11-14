using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Proyecto : BaseEntity
    {
        public string Código { get; set; }

        public string Nombre { get; set; }

        public long IdAsignatura { get; set; }

        public Asignatura Asignatura { get; set; }

        public ICollection<EstudianteProyecto> ProyectoEstudiantes { get; set; }

        public Director Director { get; set; }

        public ICollection<ProyectoCalificador> ProyectoCalificadores { get; set; }

        public Proyecto()
        {
        }
    }
}