namespace APIAcademia.Model
{
    public class Usuario : Model
    {
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public int FuncionarioId { get; set; }
        public int GrupoAcessoId { get; set; }

        public Funcionario? Funcionario { get; set; }
        public Grupo? Grupo { get; set; }
        public IEnumerable<Unidade>? UsuarioTemUnidade { get; set; }
    }
}
