using BRGAAP_back_teste.Application.DTOs;
using BRGAAP_back_teste.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BRGAAP_teste_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotaFiscalController : Controller
    {
        private readonly INotaFiscalService _notaFiscalService;

        public NotaFiscalController(INotaFiscalService notaFiscalService)
        {
            _notaFiscalService = notaFiscalService;
        }

        [HttpPost]
        public async Task<ActionResult> Incluir(NotaFiscalDTORequest request)
        {
            var response = await _notaFiscalService.InsertNotaFiscalAsync(request);
            if (response == null)
            {
                return BadRequest("Ocorreu erro ao inserir");
            }
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> BuscarPorId(Guid id)
        {
            var response = await _notaFiscalService.GetNotaFiscalAsync(id);
            if (response == null)
            {
                return BadRequest("Ocorreu erro ao inserir");
            }
            return Ok(response);
        }
        [HttpGet]
        public async Task<ActionResult> BuscarTodos(int id)
        {
            var response = await _notaFiscalService.GetAllNotaFiscalAsync();
            if (response == null)
            {
                return BadRequest("Ocorreu erro ao inserir");
            }
            return Ok(response);
        }
    }
}
