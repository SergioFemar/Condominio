using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model.Model
{
    public class Predio
    {
        public int PredioId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QtdeApartamentos { get; set; }
        public string NumeroInicialApartamento { get; set; }
        public string NumeroFinalApartamento { get; set; }
        public int CondominioId { get; set; }
        public virtual Apartamento apartamento { get; set; }
    }
}
