using APIAcademia.Model;
using APIAcademia.Repositories.Interface;
using APIAcademia.Service.Interface;

namespace APIAcademia.Service
{
    public class ExercicioService : IExercicioService
    {
        private readonly IUnitOfWork _wof;

        public ExercicioService(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public async Task<IEnumerable<Exercicio>> GetAllExercicio()
        {
            return await _wof.ExerciciosRepository.GetAllAsync();
        }

        public async Task<Exercicio> GetExercicio(int id)
        {
            var exercicio = await _wof.ExerciciosRepository.GetAsync(e => e.Id == id);

            if (exercicio == null)
                throw new KeyNotFoundException("Exercicio não encontrado");

            return exercicio;
        }

        public async Task<Exercicio> ExercicioCreate(Exercicio exercicio)
        {
            var exercicioCriado = _wof.ExerciciosRepository.Create(exercicio);
            await _wof.Commit();

            return exercicioCriado;
        }

        public async Task<Exercicio> ExercicioUpdate(int id, Exercicio exercicio)
        {
            var exercicioUpdate = await _wof.EquipamentosRepository.GetAsync(e => e.Id == id);

            if (exercicio == null)
                throw new KeyNotFoundException("Equipamento não encontrado");

            var exercicioUpdated = _wof.ExerciciosRepository.Update(exercicio);
            await _wof.Commit();

            return exercicioUpdated;
        }

        public Task<Exercicio> ExercicioDelete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
