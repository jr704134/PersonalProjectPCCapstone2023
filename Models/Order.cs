using System.ComponentModel.DataAnnotations;

namespace PersonalProjectPCCapstone2023.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; } //This is the primary key

        [Required(ErrorMessage = "Please Enter A CustomerId")]
        public int CustomerId { get; set; }

        public OrderStatus OrderStatus { get; set; }

    }
}
