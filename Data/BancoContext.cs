using BibliotecaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaMVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            
        }

        public DbSet<AlunoModel> Alunos { get; set; }

        public DbSet<LivroModel> Livros { get; set; }

        public DbSet<EmprestimoModel> Emprestimos { get; set; }
    }
}
