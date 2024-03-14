using BRGAAP_teste_back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Domain.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Task<Cliente> GetClienteByNameAsync(string nome);
    }
}
