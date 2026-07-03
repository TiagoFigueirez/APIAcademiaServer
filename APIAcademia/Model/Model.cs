using System.Text.Json.Serialization;

namespace APIAcademia.Model
{
    public class Model
    {
        public int Id { get; set; }

        [JsonIgnore]
        public bool IsAti { get; set; }
        [JsonIgnore]
        public DateTime Criacao { get; set; }
        [JsonIgnore]
        public DateTime Alteracao { get; set; }
    }
}
