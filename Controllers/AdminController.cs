using Microsoft.AspNetCore.Mvc;

namespace PersonalProjectPCCapstone2023.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult ManageAccounts()
        {
            return View();
        }
    }
}
