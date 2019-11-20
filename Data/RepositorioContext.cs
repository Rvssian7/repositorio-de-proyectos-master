using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repositorio.Models;

namespace Repositorio.Models
{
    public class RepositorioContext : DbContext
    {
        public RepositorioContext (DbContextOptions<RepositorioContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstudianteProyecto>().HasKey(ep => new { ep.IdEstudiante, ep.IdProyecto });
            modelBuilder.Entity<ProyectoCalificador>().HasKey(pc => new { pc.IdCalificador, pc.IdProyecto });
        }

        public DbSet<Repositorio.Models.Administrador> Administrador { get; set; }

        public DbSet<Repositorio.Models.Asignatura> Asignatura { get; set; }

        public DbSet<Repositorio.Models.Calificador> Calificador { get; set; }

        public DbSet<Repositorio.Models.Proyecto> Proyecto { get; set; }

        public DbSet<Repositorio.Models.Criterio> Criterio { get; set; }

        public DbSet<Repositorio.Models.Usuario> Usuario { get; set; }
    }
}
