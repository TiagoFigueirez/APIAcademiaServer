using APIAcademia.Model;
using APIAcademia.Repositories.Interface;
using APIAcademia.Service.Interface;

namespace APIAcademia.Service
{
    public class ExercicioTreinoService : IExercicioTreinoService
    {
        private readonly IUnitOfWork _wof;

        public ExercicioTreinoService(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public Task<IEnumerable<ExercicioTreino>> GetAllExercicioTreino()
        {
            return _wof.ExercicioTreinoRepository.GetAllAvailableAsync();
        }

        public async Task<ExercicioTreino> GetExercicioTreino(int id)
        {
            var exercicioTreino = await _wof.ExercicioTreinoRepository.GetAsync(e => e.Id == id);

            if (exercicioTreino == null)
                throw new KeyNotFoundException("exercicio do treino não encontrado");

            return exercicioTreino;
        }
        
        public async Task<ExercicioTreino> ExercicioTreinoCreate(ExercicioTreino exercicioTreino)
        {
            var exercicioTreinoCriado = _wof.ExercicioTreinoRepository.Create(exercicioTreino);
            await _wof.Commit();

            return exercicioTreinoCriado;
        }

        public async Task<ExercicioTreino> ExercicioTreinoUpdate(int id, ExercicioTreino exercicioTreino)
        {
            var exercicioTreinoUpdate = await _wof.ExercicioTreinoRepository.GetAsync(e => e.Id == id);

            if (exercicioTreinoUpdate == null)
                throw new KeyNotFoundException("exercicio do treino não encontrado");

            var exercicioTreinoUpdated = _wof.ExercicioTreinoRepository.Update(exercicioTreinoUpdate);
            await _wof.Commit();

            return exercicioTreinoUpdated;
        }
        public async Task<ExercicioTreino> ExercicioTreinoDelete(int id)
        {
            var exercicioTreinoDelete = await _wof.ExercicioTreinoRepository.GetAsync(e => e.Id == id);

            if (exercicioTreinoDelete == null)
                throw new KeyNotFoundException("exercicio do treino não encontrado para deletar");

            _wof.ExercicioTreinoRepository.Delete(exercicioTreinoDelete);
            await _wof.Commit();

            return exercicioTreinoDelete;
        }
    }
}
