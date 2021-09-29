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
    public class ProprietarioController : ControllerBase
    {
        private readonly IProprietarioService _proprietarioService;
        public ProprietarioController(IProprietarioService proprietarioService)
        {
            _proprietarioService = proprietarioService;
        }
        [HttpPost("SalvarProprietario")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Salvar proprietário")]
        public string Save(ProprietarioDto proprietarioDto)
        {
            return _proprietarioService.SalvarProprietario(proprietarioDto);
        }

        [HttpGet("BuscarTodos")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Buscar todos os proprietários")]
        public IEnumerable<ProprietarioDto> GetAll()
        {

            return _proprietarioService.ConsultarTodos();
        }

        [HttpDelete("DeleteProprietario")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Deletar proprietário")]
        public string Delete(ProprietarioDto proprietarioDto)
        {
            return _proprietarioService.DeletarProprietario(proprietarioDto);
        }

        [HttpPut("AtualizarProprietario")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Atualizar dados do propeietário")]
        public string Update(ProprietarioDto proprietarioDto)
        {
            return _proprietarioService.UpdateProprietario(proprietarioDto);
        }

    }
}
