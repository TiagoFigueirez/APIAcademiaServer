using APIAcademia.Model;
using APIAcademia.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIAcademia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> Get()
        {
            var usuarios = await _usuarioService.GetAllUsuario();

            return Ok(usuarios);
        }

        [HttpGet("{id:int}", Name = "ObterUsuario")]
        public async Task<ActionResult<Usuario>> Get(int id)
        {
            var usuario = await _usuarioService.GetUsuario(id);

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> Post(Usuario usuario)
        {
            var usuarioCriado = await _usuarioService.UsuarioCreate(usuario);
            return new CreatedAtRouteResult("ObterUsuario", new { id = usuario.Id }, usuarioCriado);
        }

        [HttpPut]
        public async Task<ActionResult<Usuario>> Put(int id, Usuario usuario)
        {
            if (id != usuario.Id)
                return BadRequest("Grupo não encontrado para atualizar....");

            var grupoAtualizado = await _usuarioService.UsuarioUpdate(usuario.Id, usuario);
            return Ok(grupoAtualizado);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Usuario>> Delete(int id)
        {
            await _usuarioService.UsuarioDelete(id);
            return NoContent();
        }
    }
}
