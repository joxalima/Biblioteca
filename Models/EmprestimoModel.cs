using BibliotecaMVC.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaMVC.Models
{
    public class EmprestimoModel
    {

        public EmprestimoModel() { }

        public EmprestimoModel(int id, AlunoModel aluno, LivroModel livro, DateTime? dataRetirada, DateTime? dataEntrega = null, bool emprestado = true)
        {
            ID = id;
            Aluno = aluno;
            Livro = livro;
            DataRetirada = dataRetirada;
            DataEntrega = dataEntrega;
            Emprestado = emprestado;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime? DataRetirada { get; set; }
        public DateTime? DataEntrega { get; set; }
        public bool Emprestado { get; set; }
        public AlunoModel Aluno { get; set; }
        public LivroModel Livro { get; set; }
    }
}
