using Projeto.Model.Dto;
using Projeto.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Service.Interface
{
    public interface IPredioService
    {
        String SalvarPredio(PredioDto predioDto);
        String DeletarPredio(PredioDto predioDto);
        String UpdatePredio(PredioDto predioDto);
        IEnumerable<PredioDto> ConsultarTodos();
        PredioDto BusarPorId(int id);
    }
}
