using APIAcademia.Model;

namespace APIAcademia.Service.Interface
{
    public interface IExercicioTreinoService
    {
        Task<IEnumerable<ExercicioTreino>> GetAllExercicioTreino();
        Task<ExercicioTreino> GetExercicioTreino(int id);
        Task<ExercicioTreino> ExercicioTreinoCreate(ExercicioTreino exercicioTreino);
        Task<ExercicioTreino> ExercicioTreinoUpdate(int id, ExercicioTreino exercicioTreino);
        Task<ExercicioTreino> ExercicioTreinoDelete(int id);
    }
}
