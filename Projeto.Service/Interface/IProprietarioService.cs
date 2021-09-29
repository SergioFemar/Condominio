using Projeto.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Service.Interface
{
    public interface IProprietarioService
    {
        String SalvarProprietario(ProprietarioDto proprietarioDto);
        String DeletarProprietario(ProprietarioDto proprietarioDto);
        String UpdateProprietario(ProprietarioDto proprietarioDto);
        IEnumerable<ProprietarioDto> ConsultarTodos();
        ProprietarioDto BusarPorId(int id);
    }
}
