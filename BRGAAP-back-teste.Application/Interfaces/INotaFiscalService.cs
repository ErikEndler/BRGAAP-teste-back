using BRGAAP_back_teste.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGAAP_back_teste.Application.Interfaces
{
    public interface INotaFiscalService
    {
        Task<NotaFiscalDTOResponse> GetNotaFiscalAsync(Guid id);
        Task<NotaFiscalDTOResponse> InsertNotaFiscalAsync(NotaFiscalDTORequest request);
        Task<IEnumerable<NotaFiscalDTOResponse>> GetAllNotaFiscalAsync();

    }
}
