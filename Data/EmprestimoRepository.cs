using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data
{
    public class EmprestimoRepository
    {
        public Emprestimo? Salvar(Emprestimo emprestimo) {
            return emprestimo;
        }
        public Emprestimo? Remover(Emprestimo emprestimo) {
            return emprestimo;
        }
        public Emprestimo Atualizar(Emprestimo emprestimo) {
            return emprestimo;
        }

        public List<Emprestimo>? Listar( ) {
            return [];
        }
    }
        
}
