using APIAcademia.Model;
using APIAcademia.Repositories.Interface;
using APIAcademia.Service.Interface;

namespace APIAcademia.Service
{
    public class UnidadesService : IUnidadesService
    {
        private readonly IUnitOfWork _wof;

        public UnidadesService(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public Task<IEnumerable<Unidade>> GetAllUnidade()
        {
            return _wof.UnidadesRepository.GetAllAvailableAsync();
        }

        public async Task<Unidade> GetUnidade(int id)
        {
            var unidade = await _wof.UnidadesRepository.GetAsync(u => u.Id == id);

            if (unidade == null)
                throw new KeyNotFoundException("unidade não encontrado");

            return unidade;
        }

        public async Task<Unidade> UnidadeCreate(Unidade unidade)
        {
            var unidadeCriado = _wof.UnidadesRepository.Create(unidade);
            await _wof.Commit();

            return unidadeCriado;
        }

        public async Task<Unidade> UnidadeUpdate(int id, Unidade unidade)
        {
            var unidadeUpdate = await _wof.UnidadesRepository.GetAsync(u => u.Id == id);

            if (unidadeUpdate == null)
                throw new KeyNotFoundException("unidade não encontrado");

            var unidadeUpdated = _wof.UnidadesRepository.Update(unidadeUpdate);
            await _wof.Commit();

            return unidadeUpdated;
        }
        public async Task<Unidade> UnidadeDelete(int id)
        {
            var unidadeDelete = await _wof.UnidadesRepository.GetAsync(u => u.Id == id);

            if (unidadeDelete == null)
                throw new KeyNotFoundException("exercicio do treino não encontrado para deletar");

            _wof.UnidadesRepository.Delete(unidadeDelete);
            await _wof.Commit();

            return unidadeDelete;
        }
    }
}
