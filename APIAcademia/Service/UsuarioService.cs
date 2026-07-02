using APIAcademia.Model;
using APIAcademia.Repositories.Wof;
using APIAcademia.Service.Interface;

namespace APIAcademia.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUnitOfWork _wof;

        public UsuarioService(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuario()
        {
            return await _wof.UsuarioRepository.GetAllAsync();
        }

        public async Task<Usuario> GetUsuario(int id)
        {
            var usuarioSelecionado = await _wof.UsuarioRepository.GetAsync(u => u.Id == id);

            if (usuarioSelecionado == null)
                throw new KeyNotFoundException("Grupo não encontrado");

            return usuarioSelecionado;
        }

        public async Task<Usuario> UsuarioCreate(Usuario usuario)
        { 
            var usuarioCreate = _wof.UsuarioRepository.Create(usuario);
            await _wof.Commit();

            return usuario;
        }
        public async Task<Usuario> UsuarioUpdate(int id)
        {
            var usuarioUpdate = await _wof.UsuarioRepository.GetAsync(g => g.Id == id);

            if (usuarioUpdate == null)
                throw new KeyNotFoundException("Grupo não encontrado para atualizar");

            var usuarioUpdated = _wof.UsuarioRepository.Update(usuarioUpdate);
            await _wof.Commit();

            return usuarioUpdated;
        }

        public async Task<Usuario> UsuarioDelete(int id)
        {
            var usuarioDelete = await _wof.UsuarioRepository.GetAsync(u => u.Id == id);

            if (usuarioDelete == null)
                throw new KeyNotFoundException("Grupo não encontrado para atualizar");

            usuarioDelete.IsAti = false;

            var usuarioDeleted = _wof.UsuarioRepository.Update(usuarioDelete);
            await _wof.Commit();

            return usuarioDeleted;
        }
    }
}
