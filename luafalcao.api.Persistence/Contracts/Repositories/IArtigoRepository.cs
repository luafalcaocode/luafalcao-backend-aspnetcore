using System.Threading.Tasks;
using System.Collections.Generic;
using luafalcao.api.Persistence.Entities;
using luafalcao.api.Shared.Enums;

namespace luafalcao.api.Persistence.Contracts.Repositories
{
    public interface IArtigoRepository : IRepositoryBase<Artigo>
    {
        Task<IEnumerable<Artigo>> ObterTodos(int page, int quantity, BlogEnum blog);
        Task<IEnumerable<Artigo>> ObterUltimasPublicacoes(BlogEnum blog);
        Task<int> ObterQuantidadeArtigosPorCategoria(BlogEnum blog);
        Task<Artigo> ObterPorId(int id);
        void Cadastrar(Artigo artigo);
        void Atualizar(Artigo artigo);
        void Remover(Artigo artigo);
    }
}