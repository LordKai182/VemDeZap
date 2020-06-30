using prmToolkit.NotificationPattern;
using System;

namespace VemDeZap.Domain.Entidades
{
    public abstract class EntityBase : Notifiable
    {
        public Guid Id { get; set; }

        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
