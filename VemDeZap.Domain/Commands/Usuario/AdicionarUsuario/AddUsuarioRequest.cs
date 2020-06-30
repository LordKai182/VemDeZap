using MediatR;

namespace VemDeZap.Domain.Commands.Usuario.Adicionarusuario
{
    public class AddUsuarioRequest : IRequest<Response>
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}
