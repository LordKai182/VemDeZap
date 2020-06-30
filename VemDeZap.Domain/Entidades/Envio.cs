using System;
using System.Collections.Generic;
using System.Text;

namespace VemDeZap.Domain.Entidades
{
    public class Envio : EntityBase
    {
        public Campanha Campanha { get; set; }
        public Grupo Grupo { get; set; }
        public Contato Contato { get; set; }
        public bool Enviado { get; set; }

    }
}
