using APIAcademia.Context;
using APIAcademia.Model;
using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories
{
    public class ExercicioTreinoRepository : Repository<ExercicioTreino>, IExercicioTreinoRepository
    {
        public ExercicioTreinoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
