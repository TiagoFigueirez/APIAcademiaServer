namespace APIAcademia.Model
{
    public class Unidade : Model
    {
        public string? NomeFatasia { get; set; }
        public string? Endereco { get; set; }
        public string? Estado { get; set; }
        public string? Cep { get; set; }
        public string? Numero { get; set; }
        public string? FotoIlustracao { get; set; }
        public string? Cnpj { get; set; }

        public IEnumerable<Aluno>? Alunos { get; set; }
        public IEnumerable<Funcionario>? Funcionarios { get; set; }
        public IEnumerable<Usuario>? UsuarioTemUnidade { get; set; }
        public IEnumerable<Equipamento>? Equipamentos { get; set; }

    }
}
