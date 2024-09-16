using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }
        
        [Required]
        [Display(Name = "Urun Adi")]
        public string? Name { get; set; } = string.Empty;

        [Required]
        [Range(0, 200000)]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        [Required]
        [Display(Name = "Resim")]
        public string? Image { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }
    }
}