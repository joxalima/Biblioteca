using System.ComponentModel.DataAnnotations;

namespace BibliotecaMVC.Models
{
    public class AlunoModel  
    {
        public AlunoModel() { }

        public AlunoModel(string nome, string ra, string email, string telefone, DateTime dataNascimento)
        {
            RA = ra;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }
        [Key]
        public string RA {  get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
