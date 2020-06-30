using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Entidades
{
    public class Grupo : EntityBase
    {
        public Usuario Usuario { get; set; }
        public string Nome { get; set; }
        public EnumNicho Nicho { get; set; }
    }
}
