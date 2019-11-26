using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositorio.Models
{
    public class Proyecto : BaseEntity
    {
        public string Código { get; set; }

        public string Nombre { get; set; }

        public long IdAsignatura { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MinLength(20, ErrorMessage = "La descripción es inválida")]
        
        public string Descripción { get; set; }

        public Asignatura Asignatura { get; set; }

        public ICollection<EstudianteProyecto> ProyectoEstudiantes { get; set; }

        public Director Director { get; set; }

        public ICollection<ProyectoCalificador> ProyectoCalificadores { get; set; }

        public Proyecto()
        {
        }
    }
}