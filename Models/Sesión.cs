using System;

namespace Repositorio.Models
{
    public class Sesión : BaseEntity
    {
        public Usuario Usuario { get; set; }

        public DateTime FechaDeInicio { get; set; }

        public DateTime FechaDeFinalización { get; set; }

        public Sesión() { }

    }
}