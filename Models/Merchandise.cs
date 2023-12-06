using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalProjectPCCapstone2023.Models
{
    public class Merchandise
    {
        [Key]
        public int MerchId { get; set; } //This is the primary key

        [Required(ErrorMessage = "Merch Name is required.")]
        public string MerchName { get; set;}

        public string? MerchSize {  get; set;}

        [Required(ErrorMessage = "Merch Price is required.")]
        public decimal MerchPrice { get; set; } = 0.0m;

        [Required(ErrorMessage = "Merch Category is required.")]
        public IList<Category>? Categories { get; set; } = new List<Category>();

        public IList<MerchCategory>? MerchCategories { get; set; } = new List<MerchCategory>();

        public IList<Order>? Orders { get; set; } = new List<Order>();

        public string? ImagePath { get; set; }

        public string? UserId { get; set; }

        public User? User { get; set; }

    }
}
