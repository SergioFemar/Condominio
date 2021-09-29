using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model.Dto
{
    public class ProprietarioDto
    {
        public int ProprietarioId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int ApartamentoId { get; set; }
        public string CPF { get; set; }
    }
}
