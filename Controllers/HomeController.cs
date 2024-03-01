using Microsoft.AspNetCore.Mvc;
using PhotoAlbum_Abella_Test_.Models;
using System.Diagnostics;

namespace PhotoAlbum_Abella_Test_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PC()
        {
            return View();
        }

        public IActionResult PS4()
        {
            return View();
        }

        public IActionResult XBOX()
        {
            return View();
        }

        public IActionResult nintendo()
        {
            return View();
        }

        public IActionResult under()
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
