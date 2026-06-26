namespace APIAcademia.Model
{
    public class Aluno : Model
    {
        public string? NomeCompleto { get; set; }
        public string? EMail { get; set; }
        public string? Senha { get; set; }
        public string? CaminhoFoto { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public int UnidadeId { get; set; }

        public Unidade? Unidade { get; set; }
        
    }
}
