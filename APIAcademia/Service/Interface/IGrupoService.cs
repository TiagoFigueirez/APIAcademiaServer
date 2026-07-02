using APIAcademia.Model;

namespace APIAcademia.Service.Interface
{
    public interface IGrupoService
    {
        Task<IEnumerable<Grupo>> GetAllGrupo();
        Task<Grupo> GetGrupo(int id);
        Task<Grupo> GrupoCreate(Grupo grupo);
        Task<Grupo> GrupoUpdate(int id);
        Task<Grupo> GrupoDelete(int id);
    }
}
