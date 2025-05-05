using System.ComponentModel.DataAnnotations;

namespace ProductCatalogAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        public string Category { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}