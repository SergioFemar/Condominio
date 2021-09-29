using Projeto.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositories.Interface
{
    public interface ICondominioRepository
    {
        IEnumerable<Condominio> condominio { get; }
        void Salvar(Condominio condominio);
        void Deletar(Condominio condominio);
        void Update(Condominio condominio);
        Condominio findById(int id);
    }
}
