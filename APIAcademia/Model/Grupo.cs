namespace APIAcademia.Model
{
    public class Grupo : Model
    {
        public string? Admin { get; set; }

        public IEnumerable<Usuario> Usuarios { get; set; }
    }
}
