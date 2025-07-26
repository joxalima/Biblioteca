using System.Diagnostics;
using BibliotecaMVC.Data;
using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AlunoRepository _alunoRep;

        public AlunoController()
        {
            _alunoRep = new AlunoRepository();
        }


        public IActionResult Index()
        {
            List<AlunoModel> alunos = _alunoRep.Listar();
            return View(alunos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Remover(string ra)
        {
            try 
            {
                _alunoRep.Remover(ra);
                TempData["MensagemSucesso"] = "Aluno removido com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = "Ocorreu um erro: Não foi possivel remover o aluno!";
                return RedirectToAction("Index");
            }

           
        }

        [HttpPost]
        public IActionResult Salvar(AlunoModel aluno)
        {
            _alunoRep.Salvar(aluno);
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
