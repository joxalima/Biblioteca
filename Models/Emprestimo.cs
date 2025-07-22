namespace BibliotecaMVC.Models
{
    public class Emprestimo
    {
        public string Codigo { get; set; }
        public DateTime? DataRetirada { get; set; }
        public DateTime? DataEntrega {  get; set; }

        public Aluno Aluno { get; set; }

        public Livro Livro { get; set; }


    }
}
