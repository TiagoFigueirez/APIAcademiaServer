using APIAcademia.Model;

namespace APIAcademia.Service.Interface
{
    public interface IManutecoesService
    {
        Task<IEnumerable<Manutencao>> GetAllManutencao();
        Task<Manutencao> GetManutencao(int id);
        Task<Manutencao> ManutencaoCreate(Manutencao manutencao);
        Task<Manutencao> ManutencaoUpdate(int id, Manutencao manutencao);
        Task<Manutencao> ManutencaoDelete(int id);
    }
}
