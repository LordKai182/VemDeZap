using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace VemDeZap.Domain.Commands.Usuario.AdicionarUsuario.Notification
{
    public class AvisarAdministradores : INotificationHandler<AddUsuarioNotification>
    {
        public async  Task Handle(AddUsuarioNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Novo Usuario Cadastrado, Usuario: " + notification.Usuario.PrimeiroNome);
        }
    }
}
