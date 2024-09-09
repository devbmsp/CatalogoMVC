using CatalogoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CatalogoMVC.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Username = "";
            home.Email = "";

            return View(home);
        }
 
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Perfil()
        {
            return View();
        }
        public IActionResult Register()
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
