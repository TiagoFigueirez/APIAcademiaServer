using APIAcademia.Model;
using APIAcademia.Repositories.Interface;
using APIAcademia.Service.Interface;

namespace APIAcademia.Service
{
    public class TreinoServie : ITreinoServie
    {
        private readonly IUnitOfWork _wof;

        public TreinoServie(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public Task<IEnumerable<Treino>> GetAllTreino()
        {
            return _wof.TreinoRepository.GetAllAvailableAsync();
        }

        public async Task<Treino> GetTreino(int id)
        {
            var treino = await _wof.TreinoRepository.GetAsync(t => t.Id == id);

            if (treino == null)
                throw new KeyNotFoundException("treino não encontrado");

            return treino;
        }

        public async Task<Treino> TreinoCreate(Treino treino)
        {
            var treinoCriado = _wof.TreinoRepository.Create(treino);
            await _wof.Commit();

            return treinoCriado;
        }

        public async Task<Treino> TreinoUpdate(int id, Treino treino)
        {
            var treinoUpdate = await _wof.TreinoRepository.GetAsync(t => t.Id == id);

            if (treinoUpdate == null)
                throw new KeyNotFoundException("exercicio do treino não encontrado");

            var treinoUpdated = _wof.TreinoRepository.Update(treinoUpdate);
            await _wof.Commit();

            return treinoUpdated;
        }
        public async Task<Treino> TreinoDelete(int id)
        {
            var treinoDelete = await _wof.TreinoRepository.GetAsync(t => t.Id == id);

            if (treinoDelete == null)
                throw new KeyNotFoundException("exercicio do treino não encontrado para deletar");

            _wof.TreinoRepository.Delete(treinoDelete);
            await _wof.Commit();

            return treinoDelete;
        }
    }
}
