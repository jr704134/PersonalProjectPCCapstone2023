using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalProjectPCCapstone2023.Data;

namespace PersonalProjectPCCapstone2023.Controllers
{
    [Authorize(Roles = "Owner, Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
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
