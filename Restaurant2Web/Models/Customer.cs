using System.ComponentModel.DataAnnotations;

namespace Restaurant2Web.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }


        public DateTime OrderTime { get; set; } = DateTime.Now;
    }
}
