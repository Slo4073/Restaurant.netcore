using System.ComponentModel.DataAnnotations;

namespace Restaurant2.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
    }
}
