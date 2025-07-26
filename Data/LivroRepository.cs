using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data
{
    public class LivroRepository
    {
        public LivroModel? Salvar(LivroModel livro) {
            return livro;
        }
        public LivroModel? Remover(LivroModel livro) {
            return livro;
        }
        public LivroModel Atualizar(LivroModel livro) {
            return livro;
        }

        public List<LivroModel> Listar( ) {
            List<LivroModel> livros = new List<LivroModel>
            {
                new LivroModel("001", "O Senhor dos Anéis: A Sociedade do Anel", "J.R.R. Tolkien", "Fantasia", "HarperCollins", true),
                new LivroModel("002", "1984", "George Orwell", "Ficção Científica", "Companhia das Letras", true),
                new LivroModel("003", "Dom Casmurro", "Machado de Assis", "Literatura Brasileira", "Editora Abril", false),
                new LivroModel("004", "A Revolução dos Bichos", "George Orwell", "Ficção", "Companhia das Letras", true),
                new LivroModel("005", "O Pequeno Príncipe", "Antoine de Saint-Exupéry", "Infantil", "Editora Agir", true),
                new LivroModel("006", "A Menina que Roubava Livros", "Markus Zusak", "Ficção", "Intrínseca", false),
                new LivroModel("007", "Harry Potter e a Pedra Filosofal", "J.K. Rowling", "Fantasia", "Rocco", true),
                new LivroModel("008", "O Alquimista", "Paulo Coelho", "Ficção", "HarperCollins", true),
                new LivroModel("009", "Cem Anos de Solidão", "Gabriel García Márquez", "Literatura Latino-Americana", "Editora Record", false),
                new LivroModel("010", "O Código Da Vinci", "Dan Brown", "Thriller", "Editora Sextante", true)
            };
            return livros ?? [];
        }
    }
        
}
