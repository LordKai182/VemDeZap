using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VemDeZap.Domain.Commands.Usuario.Adicionarusuario;
using VemDeZap.Infra.Repositories.Transactions;

namespace VemDeZap.Api.Controllers
{
    public class UsuarioController : Controller //Base.ControllerBase
    {
        public string Get()
        {
            return "Teste";
        }
        //private readonly IMediator _mediator;

        //public UsuarioController(IMediator mediator, IUnitOfWork unitOfWork) :base(unitOfWork)
        //{
        //    _mediator = mediator;
        //}

        //[AllowAnonymous]
        //[HttpPost]
        //[Route("api/Usuario/Adicionar")]
        //public async Task<IActionResult> Adicionar([FromBody] AddUsuarioRequest request)
        //{
        //    try
        //    {
        //        var response = await _mediator.Send(request, CancellationToken.None);
        //        return await ResponseAsync(response);
        //    }
        //    catch (System.Exception ex)
        //    {

        //        return BadRequest(ex.Message);
        //    }



        //}

    }
}
