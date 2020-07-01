using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Entidades;
using VemDeZap.Infra.Repositories.Map;

namespace VemDeZap.Infra.Repositories.Base
{
    public class VemDeZapContext : DbContext
    {
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Campanha> Campanhas { get; set; }
        DbSet<Contato> Contatos { get; set; }
        DbSet<Envio> Envios { get; set; }
        DbSet<Grupo> Grupos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=localhost; userid=postgres; password=discovoador;database=VemDeZap;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();
            modelBuilder.ApplyConfiguration<Usuario>(new MapUsuario());
            modelBuilder.ApplyConfiguration<Grupo>(new MapGrupo());
            modelBuilder.ApplyConfiguration<Contato>(new MapContato());
            modelBuilder.ApplyConfiguration<Campanha>(new MapCampanha());
            modelBuilder.ApplyConfiguration<Envio>(new MapEnvio());
            base.OnModelCreating(modelBuilder);
        }
    }
}
