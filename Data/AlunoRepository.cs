using BibliotecaMVC.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace BibliotecaMVC.Data
{
    public class AlunoRepository
    {
        public AlunoModel? Salvar(AlunoModel aluno) {
            return aluno;
        }
        public AlunoModel? Remover(AlunoModel aluno) {
            return aluno;
        }
        public AlunoModel Atualizar(AlunoModel aluno) {
            return aluno;
        }

        public List<AlunoModel> Listar( ) {
            List<AlunoModel> alunos = new List<AlunoModel>
            {
                new AlunoModel("Ana Silva Pereira", "2023001", "ana.silva@email.com", "(11) 91234-5678", new DateTime(2000, 5, 15)),
                new AlunoModel("Bruno Costa", "2023002", "bruno.costa@email.com", "(11) 92345-6789", new DateTime(1999, 8, 22)),
                new AlunoModel("Carla Oliveira", "2023003", "carla.oliveira@email.com", "(11) 93456-7890", new DateTime(2001, 3, 10)),
                new AlunoModel("Daniela Pereira", "2023004", "daniela.pereira@email.com", "(11) 94567-8901", new DateTime(2002, 12, 5)),
                new AlunoModel("Eduardo Santos", "2023005", "eduardo.santos@email.com", "(11) 95678-9012", new DateTime(2000, 7, 30)),
                new AlunoModel("Fernanda Lima", "2023006", "fernanda.lima@email.com", "(11) 96789-0123", new DateTime(1998, 11, 18)),
                new AlunoModel("Gustavo Almeida", "2023007", "gustavo.almeida@email.com", "(11) 97890-1234", new DateTime(2003, 1, 25)),
                new AlunoModel("Helena Martins", "2023008", "helena.martins@email.com", "(11) 98901-2345", new DateTime(1997, 4, 12)),
                new AlunoModel("Igor Rocha", "2023009", "igor.rocha@email.com", "(11) 99012-3456", new DateTime(2001, 9, 8)),
                new AlunoModel("Juliana Ferreira", "2023010", "juliana.ferreira@email.com", "(11) 99123-4567", new DateTime(1996, 6, 20))
            };
            return alunos ?? [];
            //teste
        }
    }
        
}
