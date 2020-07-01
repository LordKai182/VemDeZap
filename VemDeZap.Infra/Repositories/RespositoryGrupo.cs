using System;
using VemDeZap.Domain.Entidades;
using VemDeZap.Domain.Interface.Repositories;
using VemDeZap.Infra.Repositories.Base;

namespace VemDeZap.Infra.Repositories
{
    public class RepositoryGrupo : RepositoryBase<Grupo, Guid>, IRepositoryGrupo
    {
        private readonly VemDeZapContext _context;
        public RepositoryGrupo(VemDeZapContext context) : base(context)
        {
            _context = context;
        }
    }
}
