using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VemDeZap.Domain.Entidades;

namespace VemDeZap.Infra.Repositories.Map
{
    public class MapCampanha : IEntityTypeConfiguration<Campanha>
    {
        public void Configure(EntityTypeBuilder<Campanha> builder)
        {
            builder.ToTable("Campanhas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.HasOne(u => u.Usuario)
                   .WithMany()
                   .HasForeignKey("IdUsuario");
        }
    }
}
