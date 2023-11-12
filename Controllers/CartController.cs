using Microsoft.AspNetCore.Mvc;

namespace PersonalProjectPCCapstone2023.Controllers
{
    public class CartController : Controller
    {
        public IActionResult CartIndex()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
