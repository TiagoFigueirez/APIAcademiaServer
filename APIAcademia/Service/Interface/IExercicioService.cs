using APIAcademia.Model;

namespace APIAcademia.Service.Interface
{
    public interface IExercicioService
    {
        Task<IEnumerable<Exercicio>> GetAllExercicio();
        Task<Exercicio> GetExercicio(int id);
        Task<Exercicio> ExercicioCreate(Exercicio exercicio);
        Task<Exercicio> ExercicioUpdate(int id, Exercicio exercicio);
        Task<Exercicio> ExercicioDelete(int id);
    }
}
