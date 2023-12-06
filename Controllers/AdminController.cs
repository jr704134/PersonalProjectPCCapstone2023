using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalProjectPCCapstone2023.Data;
using PersonalProjectPCCapstone2023.Models;

namespace PersonalProjectPCCapstone2023.Controllers
{
    [Authorize(Roles = "Owner, Admin" )]
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

        [HttpGet]
        public IActionResult ManageAccounts()
        {
            IList<IdentityUser> users = _context.Users
                .Where(u => u.Id == null)
                .ToList();

            return View(users);
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View(new IdentityUser());
        }

        [HttpPost]
        public async Task<IActionResult> AddNewAdmin(IdentityUser user)
        {
            user.EmailConfirmed = true;
            user.Email = user.UserName;
            user.NormalizedEmail = user.NormalizedUserName;
            await userManager.CreateAsync(user, user.PasswordHash);
            await userManager.AddToRoleAsync(user, "Admin");
            _context.SaveChanges();
            return RedirectToAction("ManageAccounts");

        }

        public IActionResult AddMerch()
        {
            return View();
        }

        public IActionResult DeleteMerch()
        {
            return View();
        }

        public IActionResult EditMerch()
        {
            return View();
        }

    }
}
