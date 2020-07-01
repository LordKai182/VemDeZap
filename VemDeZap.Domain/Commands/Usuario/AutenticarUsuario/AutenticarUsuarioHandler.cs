using MediatR;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VemDeZap.Domain.Extensions;
using VemDeZap.Domain.Interface.Repositories;

namespace VemDeZap.Domain.Commands.Usuario.AutenticarUsuario
{
    public class AutenticarUsuarioHandler : Notifiable, IRequestHandler<AutenticarUsuarioResquest, AutenticarUsuarioResponse>
    {
        IMediator _mediator;
        IRepositorieUsuario _repositoryUsuario;

        public AutenticarUsuarioHandler(IMediator mediator, IRepositorieUsuario repositoryUsuario)
        {
            _mediator = mediator;
            _repositoryUsuario = repositoryUsuario;
        }

        public async Task<AutenticarUsuarioResponse> Handle(AutenticarUsuarioResquest request, CancellationToken cancellationToken)
        {
           if(request == null)
            {
                AddNotification("Request", "Request e obrigatorio");
                return null;
            }

            request.Senha = request.Senha.ConvertToMD5();

            Entidades.Usuario usuario = _repositoryUsuario.ObterPor(x => x.Email == request.Email && x.Senha == request.Senha);

            if(usuario == null)
            {
                AddNotification("Usuario", "Usuario nao encontrado");
                return new AutenticarUsuarioResponse() { Autenticado = false };
            }

            var response = (AutenticarUsuarioResponse)usuario;

            return await Task.FromResult(response);
        }
    }
}
