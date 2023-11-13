using System.ComponentModel.DataAnnotations;

namespace PersonalProjectPCCapstone2023.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } //This is the primary key

        public string? CategoryName { get; set; }

        public ICollection<Merchandise>? Merch { get; set; }

        public CategoryType CategoryType { get; set; }


    }
}
