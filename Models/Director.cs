using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Director : Profesor
    {
        public ICollection<Proyecto> Proyectos { get; set; }

        public Director()
        {
            Proyectos = new HashSet<Proyecto>();
        }
    }
}