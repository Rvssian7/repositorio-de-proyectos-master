using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Administrador : BaseEntity
    {
        public ICollection<Rúbrica> Rúbricas { get; set; }

        public Administrador() { }
    }
}