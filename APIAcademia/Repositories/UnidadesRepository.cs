using APIAcademia.Context;
using APIAcademia.Model;
using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories
{
    public class UnidadesRepository : Repository<Unidade>, IUnidadesRepository
    {
        public UnidadesRepository(AppDbContext context) : base(context)
        {
        }
    }
}
