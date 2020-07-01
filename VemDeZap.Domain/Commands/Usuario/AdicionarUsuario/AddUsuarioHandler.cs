using MediatR;
using prmToolkit.NotificationPattern;
using System;
using System.Threading;
using System.Threading.Tasks;
using VemDeZap.Domain.Commands.Usuario.Adicionarusuario;
using VemDeZap.Domain.Interface.Repositories;

namespace VemDeZap.Domain.Commands.Usuario.AdicionarUsuario
{
    public class AddUsuarioHandler : Notifiable,  IRequestHandler<AddUsuarioRequest, Response>
    {
        private readonly IMediator _mediator;
        private readonly IRepositorieUsuario _repositoryUsuario;

        public AddUsuarioHandler(IMediator mediator, IRepositorieUsuario repositoryUsuario)
        {
            _mediator = mediator;
            _repositoryUsuario = repositoryUsuario;
        }

        public async Task<Response> Handle(AddUsuarioRequest request, CancellationToken cancellationToken)
        {
            if(request == null) 
            {
                AddNotification("Request", "Informe os Dados do Usuario");
                return new Response(this);
            }
            if(_repositoryUsuario.Existe(x => x.Email == request.Email))
            {
                AddNotification("Usuario", "E-mail ja cadastrado");
                return new Response(this);
            }

            Entidades.Usuario usuario = new Entidades.Usuario(request.PrimeiroNome,request.UltimoNome,request.Senha, request.Email);
            AddNotifications(usuario);
            if (IsInvalid())
            {
                return new Response(this);
            }

           usuario =  _repositoryUsuario.Adicionar(usuario);

            var response = new Response(this, usuario);

            AddUsuarioNotification addUsernotification = new AddUsuarioNotification(usuario);

            await _mediator.Publish(addUsernotification);

            return await Task.FromResult(response);
        }
    }
}
