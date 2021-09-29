using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model.Dto
{
    public class PredioDto
    {
        public int PredioId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QtdeApartamentos { get; set; }
        public string NumeroInicialApartamento { get; set; }
        public string NumeroFinalApartamento { get; set; }
        public int CondominioId { get; set; }
    }
}
