using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data
{
    public interface IAlunoRepository
    {
        AlunoModel? Salvar(AlunoModel aluno);

        bool Remover(AlunoModel aluno);

        AlunoModel? Atualizar(AlunoModel aluno);

        List<AlunoModel>? Listar();

        AlunoModel? Buscar(string ra);
    }
}
