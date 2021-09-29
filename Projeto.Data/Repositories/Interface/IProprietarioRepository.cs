using Projeto.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositories.Interface
{
    public interface IProprietarioRepository
    {
        IEnumerable<Proprietario> proprietario { get; }
        void Salvar(Proprietario proprietario);
        void Deletar(Proprietario proprietario);
        void Update(Proprietario proprietario);
        Proprietario findById(int id);

    }
}
