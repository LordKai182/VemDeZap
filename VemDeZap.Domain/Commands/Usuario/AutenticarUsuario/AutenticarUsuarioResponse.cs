using System;

namespace VemDeZap.Domain.Commands.Usuario.AutenticarUsuario
{
    public class AutenticarUsuarioResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Autenticado { get; set; }

        public static explicit operator AutenticarUsuarioResponse(Entidades.Usuario entidade)
        {
            return new AutenticarUsuarioResponse()
            {
                Id = entidade.Id,
                Nome = entidade.PrimeiroNome,
                Autenticado = true
            };
        }
    }
}
