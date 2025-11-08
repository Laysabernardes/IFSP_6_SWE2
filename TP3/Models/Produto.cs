using System.ComponentModel.DataAnnotations;

//Desenvolvido por Laysa Bernardes e Lucas Lopes

namespace CBTSWE2_TP03.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "o preço é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "Á quantidade é obrigatória")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade no estoque não pode ser negativa")]
        public int QtdEstoque { get; set; }
    }
}
