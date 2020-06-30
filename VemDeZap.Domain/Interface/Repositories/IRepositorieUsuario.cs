using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Entidades;
using VemDeZap.Domain.Interface.Repositories.Base;

namespace VemDeZap.Domain.Interface.Repositories
{
    public interface IRepositorieUsuario : IRepositoryBase<Usuario,Guid>
    {
    }
}
