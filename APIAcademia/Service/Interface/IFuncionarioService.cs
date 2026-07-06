using APIAcademia.Model;

namespace APIAcademia.Service.Interface
{
    public interface IFuncionarioService
    {
        Task<IEnumerable<Funcionario>> GetAllFuncionarioo();
        Task<Funcionario> GetFuncionario(int id);
        Task<Funcionario> FuncionarioCreate(Funcionario funcionario);
        Task<Funcionario> FuncionarioUpdate(int id, Funcionario funcionario);
        Task<Funcionario> FuncionarioDelete(int id);
    }
}
