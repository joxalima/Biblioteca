using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data
{
    public interface ILivroRepository
    {
        LivroModel? Salvar(LivroModel livro); 



        bool Remover(LivroModel livro);

        LivroModel? Atualizar(LivroModel livro);

        List<LivroModel>? Listar();

        LivroModel? Buscar(string codigo);
    }
}
