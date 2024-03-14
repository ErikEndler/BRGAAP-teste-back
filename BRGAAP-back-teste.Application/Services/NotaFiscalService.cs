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
    public class NotaFiscalService : INotaFiscalService
    {
        private readonly INotaFiscalRepository _repository;

        private readonly IMapper _mapper;
        private readonly IClienteService _clienteService;
        private readonly IFornecedorService _fornecedorService;
        private readonly IUnitiOfWork _unitiOfWork;

        public NotaFiscalService(INotaFiscalRepository repository, IMapper mapper, IClienteService clienteService, IFornecedorService fornecedorService, IUnitiOfWork unitiOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _clienteService = clienteService;
            _fornecedorService = fornecedorService;
            _unitiOfWork = unitiOfWork;
        }

        public async Task<IEnumerable<NotaFiscalDTOResponse>> GetAllNotaFiscalAsync()
        {
            var notasFiscais = await _repository.GetAll();
            return _mapper.Map<IEnumerable<NotaFiscalDTOResponse>>(notasFiscais);
        }

        public async Task<NotaFiscalDTOResponse> GetNotaFiscalAsync(Guid id)
        {
            var notaFiscal= await _repository.GetById(id);
            return _mapper.Map<NotaFiscalDTOResponse>(notaFiscal);
        }

        public async Task<NotaFiscalDTOResponse> InsertNotaFiscalAsync(NotaFiscalDTORequest request)
        {
            var cliente = (await _clienteService.GetClienteByNameAsync(request.NomeCliente));                       
            var fornecedor = await _fornecedorService.GetFornecedorByNameAsync(request.NomeFornecedor);           
            var notaFiscal = new NotaFiscal(request.numero, request.Valor, (cliente is null ? new Cliente(request.NomeCliente) : cliente), (fornecedor is null ? new Fornecedor(request.NomeFornecedor) : fornecedor));
            var usaurioInserido = await _repository.Create(notaFiscal);
            await _unitiOfWork.Commit();
            return _mapper.Map<NotaFiscalDTOResponse>(usaurioInserido);
        }
    }
}
