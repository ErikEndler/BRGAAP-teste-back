using BRGAAP_teste_back.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Domain.Entities
{
    public class Fornecedor : BaseEntity
    {
        public string Nome { get; private set; }
        public ICollection<NotaFiscal> NotasFiscais { get; private set; }

        public Fornecedor(string nome)
        {
            ValidateDomain(nome);
        }

        public void ValidateDomain(string nome)
        {
            DomainExcptionValidation.When(String.IsNullOrEmpty(nome), " Nome não pode ser nulo");
            Nome = nome;
        }
    }
}
