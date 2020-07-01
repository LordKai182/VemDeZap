using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VemDeZap.Domain.Entidades;

namespace VemDeZap.Infra.Repositories.Map
{
    public class MapEnvio : IEntityTypeConfiguration<Envio>
    {
        public void Configure(EntityTypeBuilder<Envio> builder)
        {
            builder.ToTable("Envios");
            builder.HasKey(x => x.Id);

            builder.HasOne(u => u.Grupo)
                   .WithMany()
                   .HasForeignKey("IdGrupo");
            builder.HasOne(u => u.Contato)
                  .WithMany()
                  .HasForeignKey("IdContatos");
            builder.HasOne(u => u.Campanha)
              .WithMany()
              .HasForeignKey("IdCampanha");
        }
    }
}
