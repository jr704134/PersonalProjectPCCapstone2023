using System.ComponentModel.DataAnnotations;

namespace PersonalProjectPCCapstone2023.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }

        public ICollection<Merchandise>? Merch { get; set; }

        public CategoryType CategoryType { get; set; }


    }
}
