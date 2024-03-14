using BRGAAP_teste_back.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_teste_back.Domain.Entities
{
    public class NotaFiscal : BaseEntity
    {
        public Double Valor { get; set; }
        public string Numero {  get; set; }
        public Cliente Cliente { get; set; }
        public Fornecedor  Fornecedor { get;  set; }

        public NotaFiscal()
        {
        }

        public NotaFiscal(string numero ,double valor, Cliente cliente, Fornecedor fornecedor)
        {
            ValidateDomain(valor, numero);
            Cliente = cliente;
            Fornecedor = fornecedor;
        }
        public void ValidateDomain(double valor, string numero)
        {
            DomainExcptionValidation.When(!Double.IsPositive(valor), "Valor precisa ser positivo");
            DomainExcptionValidation.When(String.IsNullOrEmpty(numero), "Numero Nota Fiscal não pode estar vazio ou nullo");
            Valor = valor;
            Numero = numero;
        }
    }
}
