using APIAcademia.Context;
using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public IGrupoRepository? _grupoRepository;
        public IUsuarioRepository? _usuarioRepository;
        public IFuncionarioRepository? _funcionarioRepository;
        public IAlunoRepository? _alunoRepository;
        public IEquipamentosRepository? _equipamentosRepository;
        public IExerciciosRepository? _exerciciosRepository;
        public IExercicioTreinoRepository? _exercicioTreinoRepository;
        public IManutencoesRepository? _manutencoesRepository;
        public IProfessorRepository? _professorRepository;
        public ITreinoRepository? _treinoRepository;
        public IUnidadesRepository? _unidadesRepository;


        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IGrupoRepository GrupoRepository 
        {
            get
            {
                return _grupoRepository = _grupoRepository ?? new GrupoRepository(_appDbContext);
            }
        }

        public IUsuarioRepository UsuarioRepository
        {
            get
            {
                return _usuarioRepository = _usuarioRepository ?? new UsuarioRepository(_appDbContext);
            }
        }
        public IFuncionarioRepository FuncionarioRepository
        {
            get
            {
                return _funcionarioRepository = _funcionarioRepository ?? new FuncionarioRepository(_appDbContext);
            }
        }

        public IAlunoRepository AlunoRepository => _alunoRepository ?? new AlunoRepository(_appDbContext);

        public IEquipamentosRepository EquipamentosRepository => _equipamentosRepository ?? new EquipamentosRepository(_appDbContext);

        public IExerciciosRepository ExerciciosRepository => _exerciciosRepository ?? new ExerciciosRepository(_appDbContext);

        public IExercicioTreinoRepository ExercicioTreinoRepository => _exercicioTreinoRepository ?? new ExercicioTreinoRepository(_appDbContext);

        public IManutencoesRepository ManutencoesRepository => _manutencoesRepository ?? new ManutencoesRepository(_appDbContext);

        public IProfessorRepository ProfessorRepository => _professorRepository ?? new ProfessorRepository(_appDbContext);

        public ITreinoRepository TreinoRepository =>_treinoRepository ?? new TreinoRepository(_appDbContext);                                                  

        public IUnidadesRepository UnidadesRepository => _unidadesRepository ?? new UnidadesRepository(_appDbContext);

        public async Task Commit()
        {
            await _appDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
