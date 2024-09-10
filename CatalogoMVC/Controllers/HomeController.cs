using CatalogoMVC.Models;
using CatalogoMVC.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CatalogoMVC.Controllers
{
    public class HomeController : Controller

    {
        public IActionResult Index()
        {

            return View();
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
    

        public IActionResult Apagar(int Id)

        {
            bool apagado = _userRepositorio.Deletar(Id);
            if (apagado)
                TempData["MensagemSucesso"] = "Contato apagado com sucesso!";
            else
                TempData["MensagemErro"] = "Ops, não conseguimos cadastrar seu contato.";

            return RedirectToAction("Index");   
        }

        public IActionResult Editar(int Id)
        {
           HomeModel userEdit =  _userRepositorio.ListarPorId(Id);
            return View(userEdit);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        private Interface _userRepositorio;
        public HomeController(Interface UserRepositorio)
        {
            _userRepositorio = UserRepositorio;
        }

        [HttpPost]
        public IActionResult Criar(HomeModel user)
        {
            _userRepositorio.Adicionar(user);
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Alterar(HomeModel user)
        {
            _userRepositorio.Atualizar(user);
            return RedirectToAction("Index");
        }

    }
}
