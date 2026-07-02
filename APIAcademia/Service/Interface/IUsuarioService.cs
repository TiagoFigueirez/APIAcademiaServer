using APIAcademia.Model;

namespace APIAcademia.Service.Interface
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAllUsuario();
        Task<Usuario> GetUsuario(int id);
        Task<Usuario> UsuarioCreate(Usuario usuario);
        Task<Usuario> UsuarioUpdate(int id);
        Task<Usuario> UsuarioDelete(int id);
    }
}
