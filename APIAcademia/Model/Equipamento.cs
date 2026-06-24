namespace APIAcademia.Model
{
    public class Equipamento : Model
    {
        public string? Nome { get; set; }
        public string? CamonhoFoto { get; set; }
        public int UnidadeId { get; set; }

        public Unidade? Unidade { get; set; }
        public IEnumerable<Manutencao>? Manutencoes { get; set; }
        public IEnumerable<Exercicio>? Exercicios { get; set; }
    }
}
