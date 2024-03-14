using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
