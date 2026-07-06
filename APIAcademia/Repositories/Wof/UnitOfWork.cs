using APIAcademia.Context;
using APIAcademia.Repositories.Interface;

namespace APIAcademia.Repositories.Wof
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public IGrupoRepository? _grupoRepository;
        public IUsuarioRepository? _usuarioRepository;
        public IFuncionarioRepository? _funcionarioRepository;

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
