using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PersonalProjectPCCapstone2023.Data;
using PersonalProjectPCCapstone2023.Models;

namespace PersonalProjectPCCapstone2023.Controllers
{
    [Authorize(Roles = "Owner, Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        public AdminController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _context = context;
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public IActionResult ManageAccounts()
        {

            return View();
        }

        public IActionResult AddMerch()
        {
            return View();
        }
    }
}
