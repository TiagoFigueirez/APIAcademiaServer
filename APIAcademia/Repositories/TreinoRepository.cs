using APIAcademia.Context;
using APIAcademia.Model;
using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories
{
    public class TreinoRepository : Repository<Treino>, ITreinoRepository
    {
        public TreinoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
