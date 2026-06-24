namespace APIAcademia.Model
{
    public class Funcionario : Model
    {
        public string? NomeCompleto { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? NomePai { get; set; }
        public string? NomeMae { get; set; }
        public string? Pis { get; set; }
        public decimal? Salario { get; set; }
        public decimal? SalarioHora { get; set; }
        public string? Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string? CaminhoFoto { get; set; }
        public int UnidadeId { get; set; }

        public Unidade? Unidade { get; set; }
        public Professor? Professor { get; set; }
        public Usuario? Usuario { get; set; }

    }
}
