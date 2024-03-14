using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Domain.Validations
{
    public class DomainExcptionValidation : Exception
    {
        public DomainExcptionValidation(string error): base(error) { }
        public static void When(bool hasError, string error)
        {
            if (hasError) {
                throw new DomainExcptionValidation(error);
            }
        }
    }
}
