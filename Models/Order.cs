using System.ComponentModel.DataAnnotations;

namespace PersonalProjectPCCapstone2023.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; } //This is the primary key

        public int CustomerId { get; set; }

        public OrderStatus OrderStatus { get; set; }

    }
}
