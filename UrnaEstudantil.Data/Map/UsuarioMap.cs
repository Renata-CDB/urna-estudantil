using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UrnaEstudantil.Domain;

namespace UrnaEstudantil.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasColumnType("varchar(100)").IsRequired();

            builder.Property(x => x.CPF).HasColumnType("varchar(11)").IsRequired();

            builder.Property(x => x.Email).HasColumnType("varchar(30)").IsRequired();

            builder.Property(x => x.Instituicao).HasColumnType("int").IsRequired();

            builder.Property(x => x.RA).HasColumnType("varchar(30)");

            builder.Property(x => x.Senha).HasColumnType("varchar(20)").IsRequired();

            builder.Property(x => x.Perfil).HasColumnType("int").IsRequired();
        }

    }
}
