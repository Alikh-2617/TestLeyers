using Microsoft.AspNetCore.Mvc;
using Ninject;
using System.Diagnostics;
using TestLeyers.Models;
using TestLeyers.Servises.Container;
using TestLeyers.Servises.LayersServises_controller.Database;
using TestLeyers.Servises.ServisesForAddToDatabase;

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
            var FetchUser = new IocContainer().GetUserServise();

            // eller vi kan använda ninject packege och använda ninject istället för IoContainer filed 
            var ninject = new StandardKernel();

            ninject.Bind<ISendUsers>().To<GetUserFromMySQL>(); // om någon frågar om IsendUsers du kan skicka den class (GetUserFromDataBase)

            ninject.Bind<ISendUsers>().To<GetUserFromEntityFrammeWorkSQL>(); // eller istället ta den från EntityFrammeWork 

            var FetchUsers2 = ninject.Get<ISendUsers>();    

            return View(FetchUser);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}