using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data
{
    public class EmprestimoRepository
    {
        public EmprestimoModel? Salvar(EmprestimoModel emprestimo) {
            return emprestimo;
        }
        public EmprestimoModel? Remover(EmprestimoModel emprestimo) {
            return emprestimo;
        }
        public EmprestimoModel Atualizar(EmprestimoModel emprestimo) {
            return emprestimo;
        }

        public List<EmprestimoModel> Listar() {
      
            AlunoRepository alunoRepo = new AlunoRepository();
            LivroRepository livroRepo = new LivroRepository();

            List<AlunoModel> alunos = alunoRepo.Listar();
            List<LivroModel> livros = livroRepo.Listar();

            List<EmprestimoModel> emprestimos = new List<EmprestimoModel>
    {
        new EmprestimoModel("E001", alunos[0], livros[1], DateTime.Now.AddDays(-7)),
        new EmprestimoModel("E002", alunos[1], livros[3], DateTime.Now.AddDays(-3)),
        new EmprestimoModel("E003", alunos[2], livros[4], DateTime.Now.AddDays(-1), DateTime.Now)
    };

            return emprestimos;
        }
    }
}



           
        
    
        

