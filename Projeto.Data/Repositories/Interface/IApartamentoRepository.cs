using Projeto.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositories.Interface
{
    public interface IApartamentoRepository
    {
        IEnumerable<Apartamento> apartamento { get; }
        void Salvar(Apartamento apartamento);
        void Deletar(Apartamento apartamento);
        void Update(Apartamento apartamento);
        Apartamento findById(int id);
    }
}
