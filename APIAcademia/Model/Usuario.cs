using System.Text.Json.Serialization;

namespace APIAcademia.Model
{
    public class Usuario : Model
    {
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public int FuncionarioId { get; set; }
        public int GrupoAcessoId { get; set; }

        [JsonIgnore]
        public Funcionario? Funcionario { get; set; }

        [JsonIgnore]
        public Grupo? Grupo { get; set; }

        [JsonIgnore]
        public IEnumerable<Unidade>? UsuarioTemUnidade { get; set; }
    }
}
