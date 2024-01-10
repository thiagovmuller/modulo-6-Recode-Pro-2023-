using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace modulo6api.Models
{
    public class Compra
    {
        [Key]
        public int IdCompra { get; set; }
        [Required(ErrorMessage = "Campo Forma de Pagamento é obrigatório")]
        public string FormaPgto { get; set; }
        [Required(ErrorMessage = "Campo Valor Total é obrigatório")]
        public double ValorTotal { get; set; }

        [Required(ErrorMessage = "Campo Id Cliente é obrigatório")]
        public int IdCliente { get; set; }

        [JsonIgnore]
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "Campo Id Passagem é obrigatório")]
        public int IdPassagem { get; set; }

        [JsonIgnore]
        public Passagem Passagem { get; set; }


    }
}
