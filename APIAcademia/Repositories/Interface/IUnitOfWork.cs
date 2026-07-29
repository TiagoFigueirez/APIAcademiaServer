namespace APIAcademia.Repositories.Interface
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
