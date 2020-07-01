namespace VemDeZap.Domain.Entidades
{
    public class Campanha : EntityBase
    {
        protected Campanha()
        {

        }
        public string Nome { get; set; }
        public Usuario Usuario { get; set; }

    }
}
