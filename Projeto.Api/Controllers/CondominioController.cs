using Microsoft.AspNetCore.Mvc;
using Projeto.Model.Dto;
using Projeto.Service.Interface;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Projeto.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CondominioController : ControllerBase
    {
        private readonly ICondominioService _condominioService;
        public CondominioController(ICondominioService condominioService)
        {
            _condominioService = condominioService;
        }

        [HttpPost("SalvarCondominio")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Salvar um novo condomínio")]
        public string Salvar(CondominioDto condominioDto)
        {
            return _condominioService.SalvarCondominio(condominioDto);
        }

        [HttpDelete("DeletarPredio")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Deletar um condomínio")]
        public string Delete(CondominioDto condominioDto)
        {
            return _condominioService.DeletarCondominio(condominioDto);
        }

        [HttpGet("BuscarTodos")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Buscar todos condomínios")]
        public IEnumerable<CondominioDto> GetAll()
        {

            return _condominioService.ConsultarTodos();
        }

        [HttpPut("AtualizarCondominio")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Atualizar dados condomíniol")]
        public string Update(CondominioDto condominioDto)
        {
            return _condominioService.UpdateCondominio(condominioDto);
        }
    }
}
