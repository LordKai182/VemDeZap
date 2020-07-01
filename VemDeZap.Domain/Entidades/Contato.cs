using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Entidades
{
    public class Contato : EntityBase
    {
        protected Contato()
        {

        }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public EnumNicho Nicho { get; set; }
        public Usuario Usuario { get; set; }

    }
}
