using System.ComponentModel.DataAnnotations;

namespace Restaurant2Web.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Categories { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
