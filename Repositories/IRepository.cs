namespace MediatRSample.Repositories
{
    public interface IRepository<T> 
    {
        Task<IEnumerable<T>> ObterTodos();

        Task<T> Obter(int id);

        Task<int> Salvar(T item);

        Task Alterar(T item);

        Task Excluir(int id);
    }
}
