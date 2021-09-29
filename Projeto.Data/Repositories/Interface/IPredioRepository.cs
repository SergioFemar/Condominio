using Projeto.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositories.Interface
{
    public interface IPredioRepository
    {
        IEnumerable<Predio> predio { get; }
        void Salvar(Predio predio);
        void Deletar(Predio predio);
        void Update(Predio predio);
        Predio findById(int id);
    }
}
