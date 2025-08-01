using BibliotecaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaMVC.Data
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly BancoContext _repository;

        public EmprestimoRepository(BancoContext repository)
        {
            _repository = repository;
        }

        public EmprestimoModel? Atualizar(EmprestimoModel emprestimo)
        {
            try
            {
                _repository.Emprestimos.Update(emprestimo);
                _repository.SaveChanges();
                return emprestimo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public EmprestimoModel? Buscar(int id)
        {
            try
            {
                return _repository.Emprestimos
                    .Include(e => e.Aluno)
                    .Include(e => e.Livro)
                    .FirstOrDefault(x => x.ID == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<EmprestimoModel>? Listar()
        {
            try
            {
                return _repository.Emprestimos
                    .Include(e => e.Aluno)
                    .Include(e => e.Livro)
                    .ToList() ?? [];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Remover(EmprestimoModel emprestimo)
        {
            try
            {
                _repository.Emprestimos.Remove(emprestimo);
                _repository.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public EmprestimoModel? Salvar(EmprestimoModel emprestimo)
        {
            try
            {
                _repository.Emprestimos.Add(emprestimo);
                _repository.SaveChanges();
                return emprestimo;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}