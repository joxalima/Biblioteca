using BibliotecaMVC.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace BibliotecaMVC.Data
{
    public class AlunoRepository
    {
        public Aluno? Salvar(Aluno aluno) {
            return aluno;
        }
        public Aluno? Remover(Aluno aluno) {
            return aluno;
        }
        public Aluno Atualizar(Aluno aluno) {
            return aluno;
        }

        public List<Aluno> Listar( ) {
            List<Aluno> alunos = new List<Aluno>
            {
                new Aluno("Ana Silva", "2023001", "ana.silva@email.com", "(11) 91234-5678", new DateTime(2000, 5, 15)),
                new Aluno("Bruno Costa", "2023002", "bruno.costa@email.com", "(11) 92345-6789", new DateTime(1999, 8, 22)),
                new Aluno("Carla Oliveira", "2023003", "carla.oliveira@email.com", "(11) 93456-7890", new DateTime(2001, 3, 10)),
                new Aluno("Daniela Pereira", "2023004", "daniela.pereira@email.com", "(11) 94567-8901", new DateTime(2002, 12, 5)),
                new Aluno("Eduardo Santos", "2023005", "eduardo.santos@email.com", "(11) 95678-9012", new DateTime(2000, 7, 30)),
                new Aluno("Fernanda Lima", "2023006", "fernanda.lima@email.com", "(11) 96789-0123", new DateTime(1998, 11, 18)),
                new Aluno("Gustavo Almeida", "2023007", "gustavo.almeida@email.com", "(11) 97890-1234", new DateTime(2003, 1, 25)),
                new Aluno("Helena Martins", "2023008", "helena.martins@email.com", "(11) 98901-2345", new DateTime(1997, 4, 12)),
                new Aluno("Igor Rocha", "2023009", "igor.rocha@email.com", "(11) 99012-3456", new DateTime(2001, 9, 8)),
                new Aluno("Juliana Ferreira", "2023010", "juliana.ferreira@email.com", "(11) 99123-4567", new DateTime(1996, 6, 20))
            };
            return alunos ?? [];
        }
    }
        
}
