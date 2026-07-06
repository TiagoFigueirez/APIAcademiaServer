using APIAcademia.Context;
using APIAcademia.Model;
using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories
{
    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(AppDbContext context) : base(context)
        {
        }
    }
}
