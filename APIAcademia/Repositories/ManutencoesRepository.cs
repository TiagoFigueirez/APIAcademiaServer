using APIAcademia.Context;
using APIAcademia.Model;
using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories
{
    public class ManutencoesRepository : Repository<Manutencao>, IManutencoesRepository
    {
        public ManutencoesRepository(AppDbContext context) : base(context)
        {
        }
    }
}
