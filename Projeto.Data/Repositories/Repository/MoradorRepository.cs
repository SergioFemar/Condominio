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
    public class MoradorRepository : IMoradorRepository
    {
        private readonly AppDbContext _contexto;
        public MoradorRepository(AppDbContext appDbContext)
        {
            _contexto = appDbContext;
        }

        public IEnumerable<Morador> morador => _contexto.Morador;

        public void Salvar(Morador morador)
        {
            _contexto.Add(morador);
            _contexto.SaveChanges();
        }

        public void Deletar(Morador morador)
        {
            _contexto.Remove(morador);
            _contexto.SaveChanges();
        }

        public void Update(Morador morador)
        {
            _contexto.Update(morador);
            _contexto.SaveChanges();
        }

        public Morador findById(int id)
        {
            Morador morador = _contexto.Morador.Find(id);
            return morador;
        }
    }
}
