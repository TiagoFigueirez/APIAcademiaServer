using APIAcademia.Context;
using APIAcademia.Model;
using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories
{
    public class EquipamentosRepository : Repository<Equipamento>, IEquipamentosRepository
    {
        public EquipamentosRepository(AppDbContext context) : base(context)
        {
        }
    }
}
