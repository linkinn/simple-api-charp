using System.ComponentModel.DataAnnotations;

namespace SimpleAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The {0} field is required!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The {0} field is required!")]
        [Range(1, int.MaxValue, ErrorMessage = "The price musb be greater than zero!")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The {0} field is required!")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "The {0} field is required!")]
        public string? Description { get; set; }
    }
}
