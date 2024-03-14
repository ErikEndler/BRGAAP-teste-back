using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Domain.Interfaces
{
    public interface IUnitiOfWork
    {
        Task Commit();
    }
}
