using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_back_teste.Application.DTOs
{
    public class NotaFiscalDTORequest
    {
        public double Valor { get; set; }
        public string numero { get; set; }
        public string NomeCliente { get; set; }
        public string NomeFornecedor { get; set; }
    }
}
