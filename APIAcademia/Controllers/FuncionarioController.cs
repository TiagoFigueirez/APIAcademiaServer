using APIAcademia.Model;
using APIAcademia.Service;
using APIAcademia.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APIAcademia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Funcionario>>> Get()
        {
            var funcionarios = await _funcionarioService.GetAllFuncionarioo();

            return Ok(funcionarios);
        }

        [HttpGet("{id:int}", Name = "ObterGrupo")]
        public async Task<ActionResult<Funcionario>> Get(int id)
        {
            var funcionario = await _funcionarioService.GetFuncionario(id);

            return Ok(funcionario);
        }

        [HttpPost]
        public async Task<ActionResult<Funcionario>> Post(Funcionario funcionario)
        {
            var funcionarioCriada = await _funcionarioService.FuncionarioCreate(funcionario);
            return new CreatedAtRouteResult("ObterGrupo", new { id = funcionario.Id }, funcionarioCriada);
        }

        [HttpPut]
        public async Task<ActionResult<Funcionario>> Put(int id, Funcionario funcionario)
        {
            if (id != funcionario.Id)
                return BadRequest("Grupo não encontrado para atualizar....");

            var grupoAtualizado = await _funcionarioService.FuncionarioUpdate(funcionario.Id, funcionario);
            return Ok(grupoAtualizado);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Funcionario>> Delete(int id)
        {
            await _funcionarioService.FuncionarioDelete(id);
            return NoContent();
        }
    }
}
