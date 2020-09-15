using luafalcao.api.Persistence.Entities;
using luafalcao.api.Persistence.Enums;
using luafalcao.api.Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace luafalcao.api.Domain.Contracts.Services
{
    public interface IArtigoService
    {
        Task<int> ObterQuantidadeArtigosPorCategoria(BlogEnum blog);
        Task<IEnumerable<Artigo>> ObterTodos(int page, int quantity, BlogEnum blog);
        Task<IEnumerable<Artigo>> ObterUltimasPublicacoes(BlogEnum blog);
        Task<Artigo> ObterPorId(int id);
        Task Cadastrar(Artigo artigo);
        Task Atualizar(Artigo artigo);
        Task Remover(Artigo artigo);
    }
}