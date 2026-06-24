namespace APIAcademia.Model
{
    public class Exercicio :Model
    {
        public string? Nome { get; set; }
        public string? ParteDoCorpoTreino { get; set; }
        public string? CaminhoVideo { get; set; }
        public int EquipamentoId { get; set; }

        public Equipamento? Equipamento { get; set; }
        public ExercicioTreino? EquipamentoTreino { get; set; }

    }
}
