using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestLeyers.Models;
using TestLeyers.Servises.Container;

namespace TestLeyers.Controllers
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
            var userServise = new IocContainer().GetUserServis();
            return View(userServise);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}