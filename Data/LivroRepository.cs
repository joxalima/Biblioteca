using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data
{
    public class LivroRepository
    {
        public Livro? Salvar(Livro livro) {
            return livro;
        }
        public Livro? Remover(Livro livro) {
            return livro;
        }
        public Livro Atualizar(Livro livro) {
            return livro;
        }

        public List<Livro> Listar( ) {
            List<Livro> livros = new List<Livro>
            {
                new Livro("001", "O Senhor dos Anéis: A Sociedade do Anel", "J.R.R. Tolkien", "Fantasia", "HarperCollins", true),
                new Livro("002", "1984", "George Orwell", "Ficção Científica", "Companhia das Letras", true),
                new Livro("003", "Dom Casmurro", "Machado de Assis", "Literatura Brasileira", "Editora Abril", false),
                new Livro("004", "A Revolução dos Bichos", "George Orwell", "Ficção", "Companhia das Letras", true),
                new Livro("005", "O Pequeno Príncipe", "Antoine de Saint-Exupéry", "Infantil", "Editora Agir", true),
                new Livro("006", "A Menina que Roubava Livros", "Markus Zusak", "Ficção", "Intrínseca", false),
                new Livro("007", "Harry Potter e a Pedra Filosofal", "J.K. Rowling", "Fantasia", "Rocco", true),
                new Livro("008", "O Alquimista", "Paulo Coelho", "Ficção", "HarperCollins", true),
                new Livro("009", "Cem Anos de Solidão", "Gabriel García Márquez", "Literatura Latino-Americana", "Editora Record", false),
                new Livro("010", "O Código Da Vinci", "Dan Brown", "Thriller", "Editora Sextante", true)
            };
            return livros ?? [];
        }
    }
        
}
