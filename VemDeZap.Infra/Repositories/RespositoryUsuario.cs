using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Entidades;
using VemDeZap.Domain.Interface.Repositories;
using VemDeZap.Infra.Repositories.Base;

namespace VemDeZap.Infra.Repositories
{
    public class RespositoryUsuario : RepositoryBase<Usuario, Guid>, IRepositorieUsuario
    {
        private readonly VemDeZapContext _context;
        public RespositoryUsuario(VemDeZapContext context) : base(context)
        {
            context = _context;
        }
    }
}
