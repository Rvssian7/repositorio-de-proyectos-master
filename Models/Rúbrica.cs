using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Rúbrica : BaseEntity
    {
        public ICollection<Criterio> Criterios { get; set; }

        public Rúbrica()
        {
            Criterios = new HashSet<Criterio>();
        }
    }
}