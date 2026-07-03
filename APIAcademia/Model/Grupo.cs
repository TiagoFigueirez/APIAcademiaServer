using System.Text.Json.Serialization;

namespace APIAcademia.Model
{
    public class Grupo : Model
    {
        public string? Nome { get; set; }

        [JsonIgnore]
        public IEnumerable<Usuario>? Usuarios { get; set; }
    }
}
