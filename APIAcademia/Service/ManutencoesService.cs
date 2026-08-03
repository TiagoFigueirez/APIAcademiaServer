using APIAcademia.Model;
using APIAcademia.Repositories.Interface;
using APIAcademia.Service.Interface;

namespace APIAcademia.Service
{
    public class ManutencoesService : IManutecoesService
    {
        private readonly IUnitOfWork _wof;

        public ManutencoesService(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public Task<IEnumerable<Manutencao>> GetAllManutencao()
        {
            return _wof.ManutencoesRepository.GetAllAvailableAsync();
        }

        public async Task<Manutencao> GetManutencao(int id)
        {
            var manutencao = await _wof.ManutencoesRepository.GetAsync(m => m.Id == id);

            if (manutencao == null)
                throw new KeyNotFoundException("Manutencao não encontrado");

            return manutencao;
        }

        public async Task<Manutencao> ManutencaoCreate(Manutencao manutencao)
        {
            var manutencaoCriado = _wof.ManutencoesRepository.Create(manutencao);
            await _wof.Commit();

            return manutencaoCriado;
        }

        public async Task<Manutencao> ManutencaoUpdate(int id, Manutencao manutencao)
        {
            var manutencaoUpdate = await _wof.ManutencoesRepository.GetAsync(m => m.Id == id);

            if (manutencaoUpdate == null)
                throw new KeyNotFoundException("Manutencao não encontrado");

            var manutencaoUpdated = _wof.ManutencoesRepository.Update(manutencaoUpdate);
            await _wof.Commit();

            return manutencaoUpdated;
        }
        public async Task<Manutencao> ManutencaoDelete(int id)
        {
            var manutencaoDelete = await _wof.ManutencoesRepository.GetAsync(m => m.Id == id);

            if (manutencaoDelete == null)
                throw new KeyNotFoundException("Manutencao não encontrado para deletar");

            _wof.ManutencoesRepository.Delete(manutencaoDelete);
            await _wof.Commit();

            return manutencaoDelete;
        }
    }
}
