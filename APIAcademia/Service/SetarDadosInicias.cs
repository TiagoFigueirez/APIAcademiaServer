using APIAcademia.Model;
using APIAcademia.Repositories.Interface;
using APIAcademia.Service.Interface;
using Microsoft.AspNetCore.Identity;

namespace APIAcademia.Service
{
    public class SetarDadosInicias : ISetarDadosInicias
    {
        private readonly IUnitOfWork _wof;
        private List<string> Grupos = new List<string> { "SUPERADMIN", "ADMINISTRATIVO", "USUARIOS" };

        public SetarDadosInicias(IUnitOfWork wof)
        {
            _wof = wof;
        }

        public async Task DadosInicias()
        {
            foreach(string grupo in Grupos)
            {
                var grupoExistente = await _wof.GrupoRepository.GetAsync(g => g.Nome == grupo);

                if(grupoExistente == null)
                {
                    _wof.GrupoRepository.Create(new Grupo
                    {
                        Nome = grupo,
                    });
                }
            }

            await _wof.Commit();

            var usuarioSuperAdmin = await _wof.UsuarioRepository.GetAsync(u => u.Nome == "SuperAdmin");

            if (usuarioSuperAdmin != null)
                return;

                string senha = "Inv123*#";
                var hasher = new PasswordHasher<Usuario>();
                var grupoSuperAdmin = await _wof.GrupoRepository.GetAsync(g => g.Nome == "SUPERADMIN");

                var funcionarioAdmin = new Funcionario()
                {
                    NomeCompleto = "SuperAdmin",
                    Email = "admin@gmail.com",
                    CPF = "00000000000",
                    RG = "000000000",
                    NomeMae ="SUPERADMIN",
                    NomePai ="SUPERADMIN",
                    Salario = 0,
                    SalarioHora = 0,
                    Cargo ="Admin",
                    DataNascimento = DateTime.Now,
                    DataAdmissao = DateTime.Now,
                };

                var funcionarioAdminCadastrado = _wof.FuncionarioRepository.Create(funcionarioAdmin);

                var novoUsuarioAdmin = new Usuario();
                novoUsuarioAdmin!.Nome = "SuperAdmin";
                novoUsuarioAdmin.Senha = hasher.HashPassword(novoUsuarioAdmin, senha);
                novoUsuarioAdmin.FuncionarioId = funcionarioAdmin.Id;
                novoUsuarioAdmin.GrupoAcessoId = grupoSuperAdmin!.Id;

                _wof.UsuarioRepository.Create(novoUsuarioAdmin);

                await _wof.Commit();
        }
    }
}
