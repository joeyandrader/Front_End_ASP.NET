using System.ComponentModel.DataAnnotations;

namespace ConsumindoAPI.Models
{
    public class CategoriaModel
    {
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "O nome da categoria precisa ser preenchido!")]
        public string? Nome { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string? ImageUrl { get; set; }
    }
}