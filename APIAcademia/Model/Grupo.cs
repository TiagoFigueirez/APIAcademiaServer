namespace APIAcademia.Model
{
    public class Grupo : Model
    {
        public string? Nome { get; set; }

        public IEnumerable<Usuario> Usuarios { get; set; }
    }
}
