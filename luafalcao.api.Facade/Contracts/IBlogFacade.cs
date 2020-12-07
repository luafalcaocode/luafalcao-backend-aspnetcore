using System.Collections.Generic;
using System.Threading.Tasks;
using luafalcao.api.Persistence.DataTransferObjects.Artigo;
using luafalcao.api.Persistence.DataTransferObjects.Comentario;
using luafalcao.api.Shared.Enums;
using luafalcao.api.Shared.Utils;

namespace luafalcao.api.Facade.Contracts
{
    public interface IBlogFacade
    {
        Task<Message<int>> ObterQuantidadeArtigosPorCategoria(BlogEnum blog);
        Task<Message<ArtigoDto>> ObterArtigoPorId(int id);
        Task<Message<IEnumerable<ArtigoDto>>> ObterArtigosPaginados(int page, int quantity, BlogEnum blog);
        Task<Message<IEnumerable<ArtigoDto>>> ObterUltimasPublicacoes(BlogEnum blog);
        Task<Message<IEnumerable<ComentarioDto>>> ObterComentariosPorArtigo(int artigoId);
        Task<Message> InserirComentario(ComentarioCadastroDto comentario);
        Task<Message> AddLike(ArtigoDto artigo);
    }
}