using AutoMapper;
using BRGAAP_back_teste.Application.DTOs;
using BRGAAP_teste_back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_back_teste.Application.Mapping
{
    public class EntitiesMappingProfile : Profile
    {
        public EntitiesMappingProfile()
        {
            //<Origem,Destino>
                           
            CreateMap<NotaFiscal, NotaFiscalDTOResponse>();
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Fornecedor, FornecedorDTO>().ReverseMap();
        }
    }
}
