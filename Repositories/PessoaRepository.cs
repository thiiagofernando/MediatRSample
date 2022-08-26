using MediatRSample.Application.Models;
using MediatRSample.Data;
using Microsoft.EntityFrameworkCore;

namespace MediatRSample.Repositories
{
    public class PessoaRepository : IRepository<Pessoa>
    {
        private readonly AplicacaoDbContext db;
        public PessoaRepository(AplicacaoDbContext aplicacaoDbContext)
        {
            db = aplicacaoDbContext;
        }
        public async Task Alterar(Pessoa pessoa)
        {
            db.pessoa.Update(pessoa);
            await db.SaveChangesAsync();
        }

        public async Task Excluir(int id)
        {
            var pessoa = await db.pessoa.FindAsync(id);
            if (pessoa!=null)
            {
                db.pessoa.Remove(pessoa);
                await db.SaveChangesAsync(); 
            }
        }

        public async Task<Pessoa> Obter(int id)
        {
            return await db.pessoa.FindAsync(id);
        }
        public async Task<IEnumerable<Pessoa>> ObterTodos()
        {
            return await db.pessoa.ToListAsync();
        }

        public async Task<int> Salvar(Pessoa pessoa)
        {
            db.pessoa.Add(pessoa);
            return await db.SaveChangesAsync();
        }
        public void Dispose()
        {
            db?.Dispose();
        }
    }
}
