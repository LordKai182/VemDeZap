using Microsoft.VisualBasic;
using prmToolkit.NotificationPattern;
using System;
using VemDeZap.Domain.Extensions;

namespace VemDeZap.Domain.Entidades
{
    public class Usuario : EntityBase
    {
        protected Usuario()
        {

        }
        public Usuario(string primeiroNome, string ultimoNome, string senha, string email)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Senha = senha;
            Email = email;
            new AddNotifications<Usuario>(this)
                .IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 150, "Primeiro nome invalido.")
                .IfNullOrEmptyOrInvalidLength(x => x.UltimoNome, 3, 150)
                .IfNotEmail(x => x.Email)
                .IfNullOrEmptyOrInvalidLength(x => x.Senha, 3, 32);
            if (!string.IsNullOrEmpty(this.Senha))
            {
                this.Senha = Senha.ConvertToMD5();
            }

            DataCadastro = DateTime.Now;
            Ativo = false;
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Senha { get; private set; }
        public string Email { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }


    }
}
