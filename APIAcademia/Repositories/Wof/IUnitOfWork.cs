using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories.Wof
{
    public interface IUnitOfWork
    {
        IGrupoRepository  GrupoRepository { get; }
        IUsuarioRepository  UsuarioRepository { get; }
        Task Commit();
        void Dispose();
    }
}
