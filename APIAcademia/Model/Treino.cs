namespace APIAcademia.Model
{
    public class Treino : Model
    {
        public DateTime DataVencimento { get; set; }
        public int AlunoId { get; set; }

        public Aluno? Aluno { get; set; }
    }
}
