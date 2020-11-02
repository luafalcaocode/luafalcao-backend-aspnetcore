using luafalcao.api.Persistence.Entities;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace luafalcao.api.Domain.Contracts.Services
{
    public interface IComentarioService
    {
        Task<IEnumerable<Comentario>> ObterTodos();
        Task<IEnumerable<Comentario>> ObterTodos(int page, int quantity);
        Task<IEnumerable<Comentario>> ObterTodosComentariosPorArtigo(int artigoId);
        Task<Comentario> ObterPorId(int id);
        Task Cadastrar(Comentario Comentario);
        Task Atualizar(Comentario Comentario);
        Task Remover(Comentario Comentario);
    }
}