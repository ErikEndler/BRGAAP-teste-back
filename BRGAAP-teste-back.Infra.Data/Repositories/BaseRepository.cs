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
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ApplicantionDbContext Context;

        public BaseRepository(ApplicantionDbContext context)
        {
            Context = context;
        }

        public virtual async Task<T> Create(T entity)
        {
            await Context.AddAsync(entity);
            return entity;
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}
