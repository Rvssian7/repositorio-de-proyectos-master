using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Calificador : Profesor
    {
        public virtual ICollection<ProyectoCalificador> CalificadorProyectos { get; set; }

        public Calificador()
        {
        }
    }
}