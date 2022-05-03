using System.ComponentModel.DataAnnotations;

namespace Restaurant2.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Categories { get; set; }
        [Required]
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
