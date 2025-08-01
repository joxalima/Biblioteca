using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data
{
    public interface IEmprestimoRepository
    {
        EmprestimoModel? Salvar(EmprestimoModel emprestimo);

        bool Remover(EmprestimoModel emprestimo);

        EmprestimoModel? Atualizar(EmprestimoModel emprestimo);

        List<EmprestimoModel>? Listar();

        EmprestimoModel? Buscar(int codigo);
    }
}
