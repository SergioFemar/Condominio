using Projeto.Data.Contexto;
using Projeto.Data.Repositories.Interface;
using Projeto.Model.Model;
using System.Collections.Generic;

namespace Projeto.Data.Repositories.Repository
{
    public class ApartamentoRepository : IApartamentoRepository
    {
        private AppDbContext _contexto; 
        public ApartamentoRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Apartamento> apartamento => _contexto.Apartamento;

        public void Salvar(Apartamento apartamento)
        {
            _contexto.Add(apartamento);
            _contexto.SaveChanges();
        }

        public void Deletar(Apartamento apartamento)
        {
            _contexto.Remove(apartamento);
            _contexto.SaveChanges();
        }

        public void Update(Apartamento apartamento)
        {
            _contexto.Update(apartamento);
            _contexto.SaveChanges();
        }

        public Apartamento findById(int id)
        {
            Apartamento apartamento = _contexto.Apartamento.Find(id);
            return apartamento;
        }

    }
}
