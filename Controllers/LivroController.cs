using System.Diagnostics;
using BibliotecaMVC.Data;
using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class LivroController : Controller
    {
        

        public IActionResult Index(){
            LivroRepository livroRepository = new LivroRepository();
            List<LivroModel> livros = livroRepository.Listar();
            return View(livros);
        }

        public IActionResult Cadastrar()
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
