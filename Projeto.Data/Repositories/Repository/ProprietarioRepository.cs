using Projeto.Data.Contexto;
using Projeto.Data.Repositories.Interface;
using Projeto.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Repositories.Repository
{
   public class ProprietarioRepository : IProprietarioRepository
    {
        private readonly AppDbContext _contexto;
        public ProprietarioRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Proprietario> proprietario => _contexto.Proprietario;

        public void Salvar(Proprietario proprietario)
        {
            _contexto.Add(proprietario);
            _contexto.SaveChanges();
        }

        public void Deletar(Proprietario proprietario)
        {
            _contexto.Remove(proprietario);
            _contexto.SaveChanges();
        }

        public void Update(Proprietario proprietario)
        {
            _contexto.Update(proprietario);
            _contexto.SaveChanges();
        }

        public Proprietario findById(int id)
        {
            Proprietario proprietario = _contexto.Proprietario.Find(id);
            return proprietario;
        }
    }
}
