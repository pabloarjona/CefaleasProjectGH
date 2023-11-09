using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using CefaleasApp.Entities;

namespace CefaleasApp.DataAccess.SQLServer.EntityConfig
{
    public class EnfermedadEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Enfermedad> entityBuilder)
        {
            entityBuilder.ToTable("Enfermedad");
            entityBuilder.HasKey(x => x.IdEnfermedad);
            entityBuilder.Property(x => x.IdEnfermedad).IsRequired();

        }
    }
}
