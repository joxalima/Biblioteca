using BibliotecaMVC.Data;
using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoRepository _empRep;
        private readonly ILivroRepository _livroRep;
        private readonly IAlunoRepository _alunoRep;

        public EmprestimoController(IEmprestimoRepository empRep, ILivroRepository livroRep, IAlunoRepository alunoRep)
        {
            _livroRep = livroRep;
            _empRep = empRep;
            _alunoRep = alunoRep;
        }

        public ActionResult Index()
        {
            List<EmprestimoModel>? emprestimos = _empRep.Listar();
            return View(emprestimos);
        }

        public ActionResult EmprestarAluno()
        {
            List<AlunoModel>? alunos = _alunoRep.Listar();
            return View(alunos);
        }

        [HttpPost]
        public ActionResult SelecionarAluno(string ra)
        {
            if (string.IsNullOrEmpty(ra))
                return RedirectToAction("EmprestarAluno");

            TempData["RASelecionado"] = ra;
            return RedirectToAction("EmprestarLivro");
        }

        public ActionResult EmprestarLivro()
        {
            var ra = TempData["RASelecionado"]?.ToString();
            if (string.IsNullOrEmpty(ra))
                return RedirectToAction("EmprestarAluno");

            var livros = _livroRep.Listar() ?? new List<LivroModel>();
            ViewBag.RA = ra;

            
            TempData.Keep("RASelecionado");

            return View(livros);
        }

        [HttpGet]
        public ActionResult Salvar(string AlunoRA, string livroCodigo)
        {
            if (ModelState.IsValid)
            {
                AlunoModel aluno = new AlunoModel();
                aluno.RA = AlunoRA;
                LivroModel livro = new LivroModel();
                livro.Codigo = livroCodigo;
                EmprestimoModel emp = new EmprestimoModel();
                emp.Aluno = aluno;
                emp.Livro = livro;
                try
                {
                    emp.DataRetirada = DateTime.Now; 
                    emp.DataEntrega = DateTime.Now.AddDays(7); 


                    _empRep.Salvar(emp);
                    TempData["MensagemSucesso"] = "Empréstimo realizado com sucesso!";
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    TempData["MensagemErro"] = "Erro ao realizar empréstimo. Tente novamente.";
                }
            }

            
            var ra = emp.Aluno.RA ?? TempData["RASelecionado"]?.ToString();
            if (string.IsNullOrEmpty(ra))
                return RedirectToAction("EmprestarAluno");

            var livros = _livroRep.Listar() ?? new List<LivroModel>();
            ViewBag.RA = ra;
            TempData["RASelecionado"] = ra; 

            return View("EmprestarLivro", livros);
        }
    }
}