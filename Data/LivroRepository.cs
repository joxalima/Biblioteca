using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data
{
    public class LivroRepository : ILivroRepository
    {
        private readonly BancoContext _repository;

        public LivroRepository(BancoContext repository)
        {
            _repository = repository;
        }
        public LivroModel? Atualizar(LivroModel livro)
        {
            try
            {
                _repository.Livros.Update(livro);
                _repository.SaveChanges();
                return livro;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public LivroModel? Buscar(string codigo)
        {
            try
            {
                return _repository.Livros.FirstOrDefault(x => x.Codigo == codigo);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<LivroModel>? Listar()
        {
            try
            {
                return _repository.Livros.ToList() ?? [];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Remover(LivroModel livro)
        {
            try
            {
                _repository.Livros.Remove(livro);
                _repository.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public LivroModel? Salvar(LivroModel livro)
        {
            try
            {
                _repository.Livros.Add(livro);
                _repository.SaveChanges();
                return livro;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
    


