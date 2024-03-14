using AutoMapper;
using BRGAAP_back_teste.Application.DTOs;
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
    public class ClienteSevice : IClienteService
    {
        private readonly IClienteRepository _repository;

        private readonly IMapper _mapper;

        public ClienteSevice(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Cliente> GetClienteByNameAsync(string nome)
        {
            var cliente = await _repository.GetClienteByNameAsync(nome);
            return cliente;
        }  
    }
}
