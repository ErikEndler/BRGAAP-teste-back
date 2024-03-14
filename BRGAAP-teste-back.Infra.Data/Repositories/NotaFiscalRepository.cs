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
    public class NotaFiscalRepository : BaseRepository<NotaFiscal>, INotaFiscalRepository
    {
        public NotaFiscalRepository(ApplicantionDbContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<NotaFiscal>> GetAll()
        {
            return await Context.NotaFiscal
                .Include(p => p.Cliente)
                .Include(p => p.Fornecedor)
                .AsNoTracking().ToListAsync();
        }
        public override async Task<NotaFiscal> GetById(Guid id)
        {
            return await Context.NotaFiscal
                .Include(p => p.Cliente)
                .Include(p => p.Fornecedor)
                .SingleOrDefaultAsync(p => p.Id == id);
        }
    }
}
