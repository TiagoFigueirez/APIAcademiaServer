using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories.Wof
{
    public interface IUnitOfWork
    {
        IGrupoRepository  GrupoRepository { get; }
        IUsuarioRepository  UsuarioRepository { get; }
        IFuncionarioRepository  FuncionarioRepository { get; }
        Task Commit();
        void Dispose();
    }
}
