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
    public class UnitOfWork : IUnitiOfWork
    {
        private readonly ApplicantionDbContext _context;

        public UnitOfWork(ApplicantionDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                // Save changes data in context
                await _context.SaveChangesAsync();

                // Commit changes
                transaction.Commit();
            }
            catch (Exception ex)
            {
                // Rollback all changes
                transaction.Rollback();
            }

        }
    }
}
