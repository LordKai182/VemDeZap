using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Entidades;

namespace VemDeZap.Infra.Repositories.Map
{
    public class MapUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PrimeiroNome)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(x => x.UltimoNome)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Senha)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.DataCadastro)
                .IsRequired();
            builder.Property(x => x.Ativo)
                .IsRequired();
                   builder.Property(x => x.Email)
                   .IsRequired();
        }
    }
}
