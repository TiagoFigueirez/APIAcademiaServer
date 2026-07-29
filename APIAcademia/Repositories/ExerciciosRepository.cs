using APIAcademia.Context;
using APIAcademia.Model;
using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories
{
    public class ExerciciosRepository : Repository<Exercicio>, IExerciciosRepository
    {
        public ExerciciosRepository(AppDbContext context) : base(context)
        {
        }
    }
}
