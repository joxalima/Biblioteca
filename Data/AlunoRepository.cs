using BibliotecaMVC.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Linq.Expressions;

namespace BibliotecaMVC.Data
{
    public class AlunoRepository : IAlunoRepository
    {
       private readonly BancoContext _repository;

        public AlunoRepository(BancoContext repository)
        {
           _repository = repository;
        }

        public AlunoModel? Salvar(AlunoModel aluno) {
            try
            {
                _repository.Alunos.Add(aluno);
                _repository.SaveChanges();
                return aluno;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Remover(AlunoModel aluno) {
            try
            {
                _repository.Alunos.Remove(aluno);
                _repository.SaveChanges();
                return true;
            }
            catch (Exception)
            {  
            return false;
            } 
                
        }

        public AlunoModel? Atualizar(AlunoModel aluno) {
            try
            {
                _repository.Alunos.Update(aluno);
                _repository.SaveChanges();
                return aluno;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<AlunoModel>? Listar( ) {
            try
            {
                return _repository.Alunos.ToList() ?? [];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public AlunoModel? Buscar(string ra)
        {
            try
            {
                return _repository.Alunos.FirstOrDefault(x => x.RA == ra);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
        
}
