using System.ComponentModel.DataAnnotations;

namespace PersonalProjectPCCapstone2023.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; } //Primary Key

        public int PaymentNum { get; set; }

        public string PaymentType { get; set; }

        public string ExpDate { get; set; }
    }
}
