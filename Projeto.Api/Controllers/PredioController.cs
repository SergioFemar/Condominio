using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Model.Model;
using Projeto.Model.Dto;
using Projeto.Service.Interface;
using Swashbuckle.AspNetCore.Annotations;

namespace Projeto.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PredioController : ControllerBase
    {

        private readonly IPredioService _predioService;

        public PredioController(IPredioService predioService)
        {
            _predioService = predioService;
        }
       
        [HttpPost("SalvarPredio")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Salvar um novo prédio")]
         public string Save(PredioDto predioDto) {
            return _predioService.SalvarPredio(predioDto);
        }

        [HttpGet("BuscarTodos")] 
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Buscar todos os prédios")]
        public IEnumerable<PredioDto> GetAll()
        {

            return _predioService.ConsultarTodos();
        }

        [HttpDelete("DeletePredio")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Deletar um prédio")]
        public string Delete(PredioDto predioDto)
        {
            return _predioService.DeletarPredio(predioDto);
        }

        [HttpPut("AtualizarPredio")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Atualizar dados do Prédio")]
        public string Update(PredioDto predioDto)
        {
            return _predioService.UpdatePredio(predioDto);
        }
    }
}
