using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model.Dto
{
    public class ApartamentoDto
    {
        public int ApartamentoId { get; set; }
        public int Numero { get; set; }
        public int Andar { get; set; }
        public string Descricao { get; set; }
        public int PredioId { get; set; }
        
    }
}
