using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace modulo6api.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Este campo deve conter entre 5 e 60 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        [StringLength(11, ErrorMessage = "Este campo deve conter 11 caracteres", MinimumLength = 11)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo Data Nascimento é obrigatório")]
        public string DataNasc {  get; set; }

        [Required(ErrorMessage = "Campo Telefone é obrigatório")]
        public string Telefone { get; set; }

        [JsonIgnore]
        public List<Compra> Compra { get; set; }


    }
}
