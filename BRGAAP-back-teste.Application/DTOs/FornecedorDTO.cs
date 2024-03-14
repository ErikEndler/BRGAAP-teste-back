using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_back_teste.Application.DTOs
{
    public class FornecedorDTO
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }
    }
}
