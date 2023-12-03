using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PersonalProjectPCCapstone2023.Data;
using PersonalProjectPCCapstone2023.Models;

namespace PersonalProjectPCCapstone2023.Controllers
{
    public class CustomerController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext _context;

        public CustomerController(RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            this.roleManager = roleManager;
            _context = context;
        }

        public IActionResult MerchCatalog()
        {

            return View();
        }

        public IActionResult Account()
        {
            return View();
        }


        public IActionResult ViewItem()
        {

            return View();
        }

        public IActionResult NewArrivals()
        {
            return View();
        }
    }
}
