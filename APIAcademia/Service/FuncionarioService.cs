using APIAcademia.Model;
using APIAcademia.Repositories.Wof;
using APIAcademia.Service.Interface;

namespace APIAcademia.Service
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IUnitOfWork _wof;

        public FuncionarioService(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public async Task<IEnumerable<Funcionario>> GetAllFuncionarioo()
        {
            return await _wof.FuncionarioRepository.GetAllAsync();
        }

        public async Task<Funcionario> GetFuncionario(int id)
        {
            var funcinarioSelecionado = await _wof.FuncionarioRepository.GetAsync(f => f.Id == id);

            if (funcinarioSelecionado == null)
                throw new KeyNotFoundException("Funcionario não encontrado");

            return funcinarioSelecionado;
        }
        public async Task<Funcionario> FuncionarioCreate(Funcionario funcionario)
        {
            var funcinarioCreate = _wof.FuncionarioRepository.Create(funcionario);
            await _wof.Commit();

            return funcinarioCreate;
        }

        public async Task<Funcionario> FuncionarioUpdate(int id, Funcionario funcionario)
        {
            var funcinarioUpdate = await _wof.FuncionarioRepository.GetAsync(f => f.Id == id);

            if (funcinarioUpdate == null)
                throw new KeyNotFoundException("Funcionario não encontrado para atualizar");

            var funcinarioUpdated = _wof.FuncionarioRepository.Update(funcionario);
            await _wof.Commit();

            return funcinarioUpdated;
        }

        public async Task<Funcionario> FuncionarioDelete(int id)
        {
            var funcinarioDelete = await _wof.FuncionarioRepository.GetAsync(f => f.Id == id);

            if (funcinarioDelete == null)
                throw new KeyNotFoundException("Funcionario não encontrado para atualizar");

            funcinarioDelete.IsAtivo = false;

            var funcinarioDeleted = _wof.FuncionarioRepository.Update(funcinarioDelete);
            await _wof.Commit();

            return funcinarioDeleted;
        }
    }
}
