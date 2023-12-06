using Microsoft.AspNetCore.Identity;

// tutorial gave me a refresh on viewmodels
// https://www.youtube.com/watch?v=NfUccG5faBQ


namespace PersonalProjectPCCapstone2023.Models
{
    public class UserViewModel
    {
        public IList<User> Users { get; set; } = new List<User>();
        public IList<IdentityRole> Roles { get; set; } = new List<IdentityRole>();
    }
}
