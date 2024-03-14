using AutoMapper;
using BRGAAP_back_teste.Application.Interfaces;
using BRGAAP_teste_back.Domain.Entities;
using BRGAAP_teste_back.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_back_teste.Application.Services
{

    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _repository;

        private readonly IMapper _mapper;

        public FornecedorService(IFornecedorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Fornecedor> GetFornecedorByNameAsync(string nome)
        {
            var cliente = await _repository.GetFornecedorByNameAsync(nome);
            return cliente;
        }
    }
}
