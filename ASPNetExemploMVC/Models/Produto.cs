using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNetExemploMVC.Models
{
    public class Produto
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage="Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do produto deve ter no máximo 100 caractéres.")]
        public string nome { get; set; }

        [Required(ErrorMessage="Preço é obrigatório.")]
        [Range(0.01, 9999.99, ErrorMessage="Preço está fora dos limites de 0.01 e 9999.99")]
        [Column(TypeName="decimal(10,2)")]
        public decimal Preco { get; set; }
    }
}
