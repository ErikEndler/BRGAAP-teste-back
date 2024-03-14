using BRGAAP_teste_back.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> Create(T entity);
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
    }
}
