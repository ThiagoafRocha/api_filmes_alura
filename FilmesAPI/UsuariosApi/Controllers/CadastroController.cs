using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Data.Request;
using UsuariosApi.Service;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : Controller
    {
        private CadastroService _cadastroService;

        public CadastroController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto createDto)
        {
            Result resultado = _cadastroService.CadastraUsuario(createDto);
            if (resultado.IsFailed) return StatusCode(500, "Houve um erro no servidor");
            return Ok(resultado.Successes);
        }

        [HttpPost("/ativa")]
        public IActionResult AtivaContaUsuario(AtivaContaRequest request)
        {
            Result resultado = _cadastroService.AtivaContaUsuario(request);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok(resultado.Successes);
        }
    }
}
