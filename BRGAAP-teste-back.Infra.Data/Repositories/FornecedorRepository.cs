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
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(ApplicantionDbContext context) : base(context)
        {
        }
        public async Task<Fornecedor> GetFornecedorByNameAsync(string nome)
        {
            return await Context.Fornecedor.SingleOrDefaultAsync(p => p.Nome == nome);
        }
    }
}
