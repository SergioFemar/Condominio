using Projeto.Model.Dto;
using Projeto.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Service.Interface
{
    public interface ICondominioService
    {
        String SalvarCondominio(CondominioDto condominioDto);
        String DeletarCondominio(CondominioDto condominioDto);
        String UpdateCondominio(CondominioDto condominioDto);
        IEnumerable<CondominioDto> ConsultarTodos();
        CondominioDto BusarPorId(int id);
    }
}
