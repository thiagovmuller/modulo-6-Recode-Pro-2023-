using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Text.Json.Serialization;

namespace modulo6api.Models
{
    public class Passagem
    {
        [Key]
        public int IdPassagem {  get; set; }
        [Required(ErrorMessage = "Campo Cia Aérea é obrigatório")]
        public string CiaAerea { get; set; }
        [Required(ErrorMessage = "Campo Origem é obrigatório")]
        public string Origem { get; set; }
        [Required(ErrorMessage = "Campo Destino é obrigatório")]
        public string Destino { get; set; }
        [Required(ErrorMessage = "Campo Valor é obrigatório")]
        public double Valor { get; set; }

        [JsonIgnore]
        public List<Compra> Compra { get; set; }

    }
}
