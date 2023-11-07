using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalProjectPCCapstone2023.Models
{
    public class Merchandise
    {
        [Key]
        public int MerchId { get; set; } //This is the primary key

        [Required(ErrorMessage = "Merch Name is required.")]
        public string MerchName { get; set;}

        [Required(ErrorMessage = "Merch Type is required.")]
        public string MerchType { get; set; }

        [Required(ErrorMessage = "Merch Size is required.")]
        public string MerchSize { get; set; }

        [Required(ErrorMessage = "Merch Price is required.")]
        public Decimal MerchPrice { get; set; } = 0.0m;

    }
}
