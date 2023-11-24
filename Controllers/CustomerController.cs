using Microsoft.AspNetCore.Mvc;

namespace PersonalProjectPCCapstone2023.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Merchandise()
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
    }
}
