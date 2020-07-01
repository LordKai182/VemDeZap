using prmToolkit.NotificationPattern;
using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Entidades
{
    public class Grupo : EntityBase
    {
        public Grupo(Usuario usuario, string nome, EnumNicho nicho)
        {
            Usuario = usuario;
            Nome = nome;
            Nicho = nicho;
            if(usuario == null)
            {
                AddNotification("Usuario", "Informe Usuario");
            }
            new AddNotifications<Grupo>(this)
                  .IfNullOrInvalidLength(x => x.Nome, 3, 150, "Primeiro nome invalido.")
                  .IfEnumInvalid(x => x.Nicho);
                 
                  
        }

        protected Grupo()
        {

        }
        public Usuario Usuario { get; set; }
        public string Nome { get; set; }
        public EnumNicho Nicho { get; set; }
    }
}
