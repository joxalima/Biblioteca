using BibliotecaMVC.Models;

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
            catch (Exception )
            {
                return null;
            }
        }

        public EmprestimoModel? Buscar(string codigo)
        {
            try
            {
                return _repository.Emprestimos.FirstOrDefault(x => x.Codigo == codigo);
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
                return _repository.Emprestimos.ToList() ?? [];
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



           
        
    
        

