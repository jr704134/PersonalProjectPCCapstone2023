﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalProjectPCCapstone2023.Models
{
    public class User : IdentityUser
    {
        [NotMapped]
        public IList<string>? RoleNames { get; set; }

        public IList<Merchandise>? Merch { get; set; }
    }
}
