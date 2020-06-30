using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VemDeZap.Domain.Commands.Usuario.AdicionarUsuario
{
    public class AddUsuarioNotification : INotification
    {
        public Entidades.Usuario Usuario { get; set; }

        public AddUsuarioNotification(Entidades.Usuario Usuario)
        {
            this.Usuario = Usuario;
        }
    }
}
