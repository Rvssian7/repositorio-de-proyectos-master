using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Usuario : Persona
    {
        public string CorreoElectrónico { get; set; }

        public string Contraseña { get; set; }

        public ICollection<Sesión> Sesiones;

        public Usuario()
        {
            Sesiones = new HashSet<Sesión>();
        }
    }
}