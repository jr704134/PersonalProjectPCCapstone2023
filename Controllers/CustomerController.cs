using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using PersonalProjectPCCapstone2023.Data;
using PersonalProjectPCCapstone2023.Models;
using System.Security.Claims;


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

        [AllowAnonymous]
        [HttpGet]
        public IActionResult MerchCatalog()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            IList<Merchandise> merch = _context.Merch.Include(m => m.MerchCategories)
                .ThenInclude(m => m.Category)
                .Where(m => m.UserId == null)
                .ToList();

            return View(merch);
        }

        [HttpGet]
        public IActionResult ViewItem(int? Id)
        {
            var merch = _context.Merch.Where(m => m.MerchId == Id).FirstOrDefault();

            if (merch == null)
            { 
                RedirectToAction("MerchCatalog");
            }

            return View(merch);
        }

        public IActionResult NewArrivals()
        {
            return View();
        }

        public IActionResult TShirtView()
        {
            return View();
        }

        public IActionResult SweaterView()
        {
            return View();
        }

        public IActionResult HatView()
        {
            return View();
        }

        public IActionResult HoodieView()
        {
            return View();
        }

        public IActionResult BeanieView()
        {
            return View();
        }

        public IActionResult OtherView()
        {
            return View();
        }
    }
}



