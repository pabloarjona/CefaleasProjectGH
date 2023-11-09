
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CefaleasApp.Entities;

namespace CefaleasApp.DataAccess.SQLServer.EntityConfig
{
    public class PacienteEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Paciente> entityBuilder)
        {
            entityBuilder.ToTable("Paciente");
            entityBuilder.HasKey(x => x.IdPaciente);
            entityBuilder.Property(x => x.IdPaciente).IsRequired();
            entityBuilder.HasOne(x => x.Cuestionario).WithOne(x => x.Paciente).HasForeignKey<Paciente>(x => x.IdPaciente).OnDelete(DeleteBehavior.Cascade);
            // para relaciones una a muchas
            entityBuilder.HasOne(x => x.Usuario).WithMany(x => x.Pacientes).HasForeignKey(x => x.IdUsuario).OnDelete(DeleteBehavior.Cascade);
            //es  necesaria esa clave
            entityBuilder.Property(x => x.IdUsuario).IsRequired();
        }
    }
}
