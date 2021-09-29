using Microsoft.AspNetCore.Mvc;
using Projeto.Model.Dto;
using Projeto.Service.Interface;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApartamentoController : ControllerBase
    {
        private readonly IApartamentoService _apartamentoService;
        public ApartamentoController(IApartamentoService apartamentoService)
        {
            _apartamentoService = apartamentoService;

        }

        [HttpPost("SalvarApartamento")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Salvar um novo apartamento")]
        public string Save(ApartamentoDto apartamentoDto)
        {
            return _apartamentoService.SalvarApartamento(apartamentoDto);
        }

        [HttpGet("BuscarTodos")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Buscar todos os apartamentos")]
        public IEnumerable<ApartamentoDto> GetAll()
        {

            return _apartamentoService.ConsultarTodos();
        }

        [HttpDelete("DeleteApartamento")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Deletar um apartamento")]
        public string Delete(ApartamentoDto apartamentoDto)
        {
            return _apartamentoService.DeletarApartamento(apartamentoDto);
        }

        [HttpPut("AtualizarApartamento")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Atualizar dados do Apartamento")]
        public string Update(ApartamentoDto apartamentoDto)
        {
            return _apartamentoService.UpdatePredio(apartamentoDto);
        }
    }
}
