using System.ComponentModel.DataAnnotations;

namespace DigitalCity.ASPNET.Validation.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }

    public class ProductForm
    {
        [Required]
        [StringLength(100, MinimumLength =2)]
        public string Name { get; set; }
        
        [Required]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
    }
}
