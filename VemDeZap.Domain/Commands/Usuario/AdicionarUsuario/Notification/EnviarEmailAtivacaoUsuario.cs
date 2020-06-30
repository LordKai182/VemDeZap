using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace VemDeZap.Domain.Commands.Usuario.AdicionarUsuario.Notification
{
    public class EnviarEmailAtivacaoUsuario : INotificationHandler<AddUsuarioNotification>
    {
        public async  Task Handle(AddUsuarioNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Enviar E-mail para Usuario" + notification.Usuario.PrimeiroNome);
        }
    }
}
