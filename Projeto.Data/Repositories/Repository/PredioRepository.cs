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
    public class PredioRepository : IPredioRepository
    {
        private readonly AppDbContext _contexto;
        public PredioRepository(AppDbContext appDbContext)
        {
            _contexto = appDbContext;
        }

        public IEnumerable<Predio> predio => _contexto.Predio;

        public void Salvar(Predio predio)
        {
            _contexto.Add(predio);
            _contexto.SaveChanges();
        }

        public void Deletar(Predio predio)
        {
            _contexto.Remove(predio);
            _contexto.SaveChanges();
        }

        public void Update(Predio predio)
        {
            _contexto.Update(predio);
            _contexto.SaveChanges();
        }

        public Predio findById(int id)
        {
            Predio predio = _contexto.Predio.Find(id);
            return predio;
        }
    }
}
