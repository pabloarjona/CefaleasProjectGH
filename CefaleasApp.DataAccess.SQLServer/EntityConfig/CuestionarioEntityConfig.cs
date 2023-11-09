using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using CefaleasApp.Entities;

namespace CefaleasApp.DataAccess.SQLServer.EntityConfig
{
    public class CuestionarioEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Cuestionario> entityBuilder)
        {

            entityBuilder.ToTable("Cuestionario");
            entityBuilder.HasKey(x => x.IdPaciente);
            entityBuilder.Property(x => x.IdPaciente).IsRequired();
            // para relaciones una a muchas
            //entityBuilder.HasOne(x=> x.IdPaciente)
            //entityBuilder.HasOne(x => x.Usuario).WithMany(x => x.Cuestionarios).HasForeignKey(x => x.IdUsuario);
            //entityBuilder.HasOne(x => x.Paciente).WithOne(x => x.Cuestionario).HasForeignKey<Paciente>(x => x.IdPaciente).OnDelete(DeleteBehavior.Cascade);
            entityBuilder.HasOne(x => x.Enfermedad).WithMany(x => x.Cuestionarios).HasForeignKey(x => x.IdEnfermedad);
            //entityBuilder.HasOne(x => x.Paciente).WithOne(x => x.Cuestionario).HasForeignKey(x=> x.);
            //es  necesaria esa clave

            //entityBuilder.Property(x => x.IdUsuario).IsRequired();
            //entityBuilder.Property(x => x.IdPaciente).IsRequired();



        }
    }
}
