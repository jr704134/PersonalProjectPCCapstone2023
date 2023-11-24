namespace PersonalProjectPCCapstone2023.Models
{
    public class MerchCategory
    {
        public int MerchId { get; set; }

        public Merchandise? Merchandise { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
