using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VemDeZap.Domain.Entidades;

namespace VemDeZap.Infra.Repositories.Map
{
    public class MapContato : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contatos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(x => x.Nicho)
                .IsRequired();
            builder.HasOne(u => u.Usuario)
                   .WithMany()
                   .HasForeignKey("IdUsuario");
            builder.Property(c => c.Telefone)
                   .IsRequired();
        }
    }
}
