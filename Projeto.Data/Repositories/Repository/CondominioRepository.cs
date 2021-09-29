using Projeto.Data.Contexto;
using Projeto.Data.Repositories.Interface;
using Projeto.Model.Model;
using System.Collections.Generic;

namespace Projeto.Data.Repositories.Repository
{
    public class CondominioRepository : ICondominioRepository
    {
        private readonly AppDbContext _contexto;

        
        public CondominioRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Condominio> condominio => _contexto.Condominio;

        public void Salvar(Condominio condomoinio)
        {
            _contexto.Add(condomoinio);
            _contexto.SaveChanges();
        }

        public void Deletar(Condominio condominio)
        {
            _contexto.Remove(condominio);
            _contexto.SaveChanges();
        }

        public void Update(Condominio condominio)
        {
            _contexto.Update(condominio);
            _contexto.SaveChanges();
        }

        public Condominio findById(int id)
        {
            Condominio condominio = _contexto.Condominio.Find(id);
            return condominio;
        }



    }
}
