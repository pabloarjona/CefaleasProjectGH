using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CefaleasApp.DataAccess.SQLServer.EntityConfig;
using CefaleasApp.Entities;

namespace CefaleasApp.DataAccess.SQLServer
{
    public class CefaleasContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Cuestionario> Cuestionario { get; set; }
        public DbSet<Enfermedad> Enfermedad { get; set; }
        public CefaleasContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UsuarioEntityConfig.SetEntityBuilder(modelBuilder.Entity<Usuario>());
            PacienteEntityConfig.SetEntityBuilder(modelBuilder.Entity<Paciente>());
            CuestionarioEntityConfig.SetEntityBuilder(modelBuilder.Entity<Cuestionario>());
            EnfermedadEntityConfig.SetEntityBuilder(modelBuilder.Entity<Enfermedad>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
