using System.Diagnostics;
using BibliotecaMVC.Data;
using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class AlunoController : Controller
    {
        

        public IActionResult Index()
        {
            AlunoRepository alunoRepository = new AlunoRepository();
            List<AlunoModel> alunos = alunoRepository.Listar();
            return View(alunos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(AlunoModel aluno)
        {
            AlunoRepository alunoRep = new AlunoRepository();
            alunoRep.Salvar(aluno);
            TempData["MensagemSucesso"] = "Aluno cadastrado com sucesso";
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
