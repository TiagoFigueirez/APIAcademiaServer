namespace APIAcademia.Repositories.Interface
{
    public interface IUnitOfWork
    {
        IGrupoRepository  GrupoRepository { get; }
        IUsuarioRepository  UsuarioRepository { get; }
        IAlunoRepository AlunoRepository { get; }
        IEquipamentosRepository EquipamentosRepository { get; }
        IExerciciosRepository ExerciciosRepository { get; }
        IFuncionarioRepository  FuncionarioRepository { get; }
        IExercicioTreinoRepository ExercicioTreinoRepository { get; }
        IManutencoesRepository ManutencoesRepository { get; }
        IProfessorRepository ProfessorRepository { get; }
        ITreinoRepository TreinoRepository { get; }
        IUnidadesRepository UnidadesRepository { get; }
        Task Commit();
        void Dispose();
    }
}
