using Projeto.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Service.Interface
{
    public interface IApartamentoService
    {
        String SalvarApartamento(ApartamentoDto apartamentoDto);
        String DeletarApartamento(ApartamentoDto apartamentoDto);
        String UpdatePredio(ApartamentoDto apartamentoDto);
        IEnumerable<ApartamentoDto> ConsultarTodos();
        ApartamentoDto BusarPorId(int id);

    }
}
