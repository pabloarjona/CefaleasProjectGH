using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CefaleasApp.DataAccess.SQLServer.EntityConfig
{
    public class UsuarioEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Entities.Usuario> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Usuario");
            entityTypeBuilder.HasKey(x => x.IdUsuario);
            entityTypeBuilder.Property(x => x.IdUsuario).IsRequired();
        }
    }
}
