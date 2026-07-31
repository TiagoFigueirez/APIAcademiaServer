using APIAcademia.Model;

namespace APIAcademia.Service.Interface
{
    public interface ITreinoServie
    {
        Task<IEnumerable<Treino>> GetAllTreino();
        Task<Treino> GetTreino(int id);
        Task<Treino> TreinoCreate(Treino treino);
        Task<Treino> TreinoUpdate(int id, Treino treino);
        Task<Treino> TreinoDelete(int id);
    }
}
