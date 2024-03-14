using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_back_teste.Application.DTOs
{
    public class NotaFiscalDTOResponse
    {
        public Guid Id { get; set; }
        public double Valor { get; set; }
        public string numero {  get; set; }
        public ClienteDTO Cliente { get; set; }
        public FornecedorDTO Fornecedor { get; set; }
    }
}
