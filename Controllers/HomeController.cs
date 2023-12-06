using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using PersonalProjectPCCapstone2023.Data;
using PersonalProjectPCCapstone2023.Models;
using System.Diagnostics;

namespace PersonalProjectPCCapstone2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var slideshowImages = new List<SlideshowImage>
            {
                new SlideshowImage { ImageUrl = "Images/Beanie.jpg", AltText = "Slide 1" },
                new SlideshowImage { ImageUrl = "Images/Hoodie.jpg", AltText = "Slide 2" },
                new SlideshowImage { ImageUrl = "Images/Hat.jpg", AltText = "Slide 3"}
            };

            return View(slideshowImages);
        }

        [AllowAnonymous]
        public IActionResult About()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}