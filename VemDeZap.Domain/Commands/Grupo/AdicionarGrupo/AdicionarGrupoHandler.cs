using MediatR;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VemDeZap.Domain.Interface.Repositories;

namespace VemDeZap.Domain.Commands.Grupo.AdicionarGrupo
{
    public class AdicionarGrupoHandler : Notifiable, IRequestHandler<AdicionarGrupoRequest, Response>
    {
        private readonly IMediator _mediator;
        private readonly IRepositoryGrupo _repositoryGrupo;
        private readonly IRepositorieUsuario _repositoryUsuario;

        public AdicionarGrupoHandler(IMediator mediator, IRepositoryGrupo repositoryGrupo, IRepositorieUsuario repositoryUsuario)
        {
            _mediator = mediator;
            _repositoryGrupo = repositoryGrupo;
            _repositoryUsuario = repositoryUsuario;
        }

        public async Task<Response> Handle(AdicionarGrupoRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                AddNotification("Request", "Informe os Dados do Usuario");
                return new Response(this);
            }

            var usuario = _repositoryUsuario.ObterPorId(request.IdUsuario);

            Entidades.Grupo grupo = new Entidades.Grupo(usuario, request.Nome, request.Nicho);
            AddNotifications(usuario);
            if (IsInvalid())
            {
                return new Response(this);
            }

            grupo = _repositoryGrupo.Adicionar(grupo);

            var response = new Response(this, grupo);

            // AddUsuarioNotification addUsernotification = new AddUsuarioNotification(usuario);

           //  await _mediator.Publish(addUsernotification);

            return await Task.FromResult(response);
        }
    }
}
