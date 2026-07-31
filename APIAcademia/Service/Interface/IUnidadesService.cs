using APIAcademia.Model;

namespace APIAcademia.Service.Interface
{
    public interface IUnidadesService
    {
        Task<IEnumerable<Unidade>> GetAllUnidade();
        Task<Unidade> GetUnidade(int id);
        Task<Unidade> UnidadeCreate(Unidade unidade);
        Task<Unidade> UnidadeUpdate(int id, Unidade unidade);
        Task<Unidade> UnidadeDelete(int id);
    }
}
