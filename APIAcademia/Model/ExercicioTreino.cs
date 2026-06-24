namespace APIAcademia.Model
{
    public class ExercicioTreino : Model
    {
        public int? Series { get; set; }
        public int? Repeticoes { get; set; }
        public int? ExercicioId { get; set; }
        public int? TreinoId { get; set; }

        public Exercicio? Exercicio { get; set; }
        public Treino? Treino { get; set; }
    }
}
