using APIAcademia.Model;
using APIAcademia.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIAcademia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoService _grupoService;
        public GrupoController(IGrupoService grupoService)
        {
            _grupoService = grupoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grupo>>> Get()
        {
            var grupos = await _grupoService.GetAllGrupo();

            return Ok(grupos);
        }

        [HttpGet("{id:int}", Name = "ObterGrupo")]
        public async Task<ActionResult<Grupo>> Get(int id)
        {
            var grupo = await _grupoService.GetGrupo(id);

            return Ok(grupo);
        }

        [HttpPost]
        public async Task<ActionResult<Grupo>> Post(Grupo grupo)
        {
            var cateoriaCriada = await _grupoService.GrupoCreate(grupo);
            return new CreatedAtRouteResult("ObterGrupo", new { id = grupo.Id },cateoriaCriada);
        }

       [HttpPut]
        public async Task<ActionResult<Grupo>> Put(int id, Grupo grupo)
        {
            if (id != grupo.Id)
                return BadRequest("Grupo não encontrado para atualizar....");

            var grupoAtualizado = await _grupoService.GrupoUpdate(grupo.Id, grupo);
            return Ok(grupoAtualizado);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Grupo>> Delete(int id)
        {
            await _grupoService.GrupoDelete(id);
            return NoContent();
        }

    }
}
