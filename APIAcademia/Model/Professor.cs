namespace APIAcademia.Model
{
    public class Professor : Model
    {
        public string? Cref { get; set; }
        public string? Especialidade { get; set; }
        public int funcionarioId { get; set; }

        public Funcionario? funcionario {  get; set; }
    }
}
