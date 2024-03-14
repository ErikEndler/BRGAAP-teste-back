using BRGAAP_teste_back.Domain.Entities;
using BRGAAP_teste_back.Domain.Interfaces;
using BRGAAP_teste_back.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicantionDbContext context) : base(context)
        {
        }
        public async Task<Cliente> GetClienteByNameAsync(string nome)
        {
            return await Context.Cliente.SingleOrDefaultAsync(p => p.Nome == nome);
        }
    }    
    
}
