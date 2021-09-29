using System.Collections.Generic;

namespace Projeto.Model.Model
{
    public class Condominio
    {
        public int CondominioId { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CNPJ { get; set; }

        public virtual List<Predio> predio { get; set; }
    }
}
