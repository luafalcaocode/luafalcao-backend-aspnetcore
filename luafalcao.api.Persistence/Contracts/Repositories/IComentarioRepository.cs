using System.Threading.Tasks;
using System.Collections.Generic;
using luafalcao.api.Persistence.Entities;

namespace luafalcao.api.Persistence.Contracts.Repositories
{
    public interface IComentarioRepository : IRepositoryBase<Comentario>
    {
        Task<IEnumerable<Comentario>> ObterTodos();
        Task<IEnumerable<Comentario>> ObterTodos(int page, int quantity);
        Task<Comentario> ObterPorId(int id);
        void Cadastrar(Comentario comentario);
        void Atualizar(Comentario comentario);
        void Remover(Comentario comentario);
    }
}