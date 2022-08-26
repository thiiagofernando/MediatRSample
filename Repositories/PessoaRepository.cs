using MediatRSample.Application.Models;

namespace MediatRSample.Repositories
{
    public class PessoaRepository : IRepository<Pessoa>
    {
        private static Dictionary<int, Pessoa> pessoas = new Dictionary<int, Pessoa>();
        public async Task Alterar(Pessoa pessoa)
        {
            await Task.Run(() =>
            {
                pessoas.Remove(pessoa.Id);
                pessoas.Add(pessoa.Id, pessoa);
            });
        }

        public async Task Excluir(int id)
        {
            await Task.Run(() => pessoas.Remove(id));
        }

        public async Task<Pessoa> Obter(int id)
        {
            return await Task.Run(() => pessoas.GetValueOrDefault(id));
        }
        public async Task<IEnumerable<Pessoa>> ObterTodos()
        {
            return await Task.Run(() => pessoas.Values.ToList());
        }

        public async Task<Pessoa> Salvar(Pessoa pessoa)
        {
            return await Task.Run(() => {
                var id = pessoas.Count() + 1;
                pessoa.Id = id;
                pessoas.Add(id, pessoa);
                return pessoa;
            });
        }
    }
}
