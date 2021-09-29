using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model.Model
{
    public class Apartamento
    {
        public int ApartamentoId { get; set; }
        public int Numero { get; set; }
        public int Andar { get; set; }
        public string Descricao { get; set; }
        public int PredioId { get; set; }
        public virtual Proprietario proprietario { get; set; }
        public virtual Morador Morador { get; set; }
    }
}
