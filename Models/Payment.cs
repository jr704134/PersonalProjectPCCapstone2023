using System.ComponentModel.DataAnnotations;

namespace PersonalProjectPCCapstone2023.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; } //Primary Key

        public string NameOnCard { get; set; }

        public int PaymentNum { get; set; }

        public int CVC { get; set; }

        public string PaymentType { get; set; }

        public string ExpDate { get; set; }
    }
}
