using System.ComponentModel.DataAnnotations;

namespace BibliotecaMVC.Models
{

    public class LivroModel
    {
        public LivroModel()
        {
        }

        public LivroModel(string codigo, string titulo, string autor, string categoria, string editora, bool disponivel ) {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            Categoria = categoria;
            Editora = editora;
            Disponivel = disponivel;

        }
        [Key]
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public string Editora { get; set; }
        public bool Disponivel { get; set; }

    }
}