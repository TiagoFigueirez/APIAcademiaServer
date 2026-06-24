namespace APIAcademia.Model
{
    public class Manutencao : Model
    {
        public DateTime? Data { get; set; }
        public decimal Valro { get; set; }
        public int EquipamentoId { get; set; }

        public Equipamento Equipamento { get; set; }
    }
}
