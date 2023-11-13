using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PersonalProjectPCCapstone2023.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        
        public IActionResult ManageAccounts()
        {
            return View();
        }
    }
}
