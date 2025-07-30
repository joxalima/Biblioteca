using BibliotecaMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaMVC.Models
{
    public class EmprestimoModel
    {

        public EmprestimoModel(){}

public  EmprestimoModel(string codigo, AlunoModel aluno, LivroModel livro, DateTime? dataRetirada, DateTime? dataEntrega = null)
{
    Codigo = codigo;
    Aluno = aluno;
    Livro = livro;
    DataRetirada = dataRetirada;
    DataEntrega = dataEntrega;
}
        [Key]
        public string Codigo { get; set; }
        public DateTime? DataRetirada { get; set; }
        public DateTime? DataEntrega {  get; set; }

        public AlunoModel Aluno { get; set; }

        public LivroModel Livro { get; set; }
    }
}
