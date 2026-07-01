using APIAcademia.Context;
using APIAcademia.Model;
using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories
{
    public class GrupoRepository : Repository<Grupo>, IGrupoRepository
    {
        public GrupoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
