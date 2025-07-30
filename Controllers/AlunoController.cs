using System.Diagnostics;
using BibliotecaMVC.Data;
using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepository _alunoRep;

        public AlunoController(IAlunoRepository repository)
        {
            _alunoRep = repository;
        }


        public IActionResult Index()
        {
            List<AlunoModel>? alunos = _alunoRep.Listar();
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

        [HttpGet("Aluno/Editar/{ra}")]
        public IActionResult Editar(string ra)
        {
            try
            {
                AlunoModel? aluno = _alunoRep.Buscar(ra);

                if (aluno == null)
                {
                    TempData["MensagemErro"] = "Ocorreu um erro: Aluno inexistente!";
                    return RedirectToAction("Index");
                } else
                {
                    return View(aluno);
                }
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = "Ocorreu um erro ao buscar o Aluno!";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(AlunoModel aluno)
        {
            _alunoRep.Atualizar(aluno);
            TempData["MensagemSucesso"] = "Aluno atualizado com sucesso";
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
