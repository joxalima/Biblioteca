using System.Diagnostics;
using BibliotecaMVC.Data;
using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class LivroController : Controller
    {

        private readonly ILivroRepository _livroRep;

        public LivroController(ILivroRepository repository)
        {
            _livroRep = repository;
        }

        public IActionResult Index(){
           
            List<LivroModel>? livros = _livroRep.Listar();
            return View(livros);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Remover(string codigo)
        {
            try
            {
                LivroModel livro = new LivroModel();
                livro.Codigo = codigo;
                _livroRep.Remover(livro);
                TempData["MensagemSucesso"] = "Livro removido com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = "Ocorreu um erro: Não foi possivel remover o livro!";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Salvar(LivroModel livro)
        {
            _livroRep.Salvar(livro);
            TempData["MensagemSucesso"] = "Livro cadastrado com sucesso";
            return RedirectToAction("Index");
        }

        [HttpGet("Livro/Editar/{codigo}")]
        public IActionResult Editar(string codigo)
        {
            try
            {
                LivroModel? livro = _livroRep.Buscar(codigo);

                if (livro == null)
                {
                    TempData["MensagemErro"] = "Ocorreu um erro: Livro inexistente!";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(livro);
                }
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = "Ocorreu um erro ao buscar o Livro!";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(LivroModel livro)
        {
            _livroRep.Atualizar(livro);
            TempData["MensagemSucesso"] = "Livro atualizado com sucesso";
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
