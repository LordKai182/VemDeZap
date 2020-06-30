using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Entidades;

namespace VemDeZap.Infra.Repositories.Map
{
    public class MapGrupo : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("Grupos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(x => x.Nicho)
                .IsRequired();
            builder.HasOne(u => u.Usuario).WithMany().HasForeignKey("IdUsuario");
        }
    }
}
