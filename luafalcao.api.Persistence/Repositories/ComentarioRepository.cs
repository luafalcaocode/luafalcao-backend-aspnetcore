using luafalcao.api.Persistence.Contracts.Repositories;
using luafalcao.api.Persistence.Entities;
using luafalcao.api.Persistence.Contexts;

using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System;

namespace luafalcao.api.Persistence.Repositories
{
    public class ComentarioRepository : RepositoryBase<Comentario>, IComentarioRepository
    {
        public ComentarioRepository(RepositoryContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Comentario>> ObterTodos()
        {
            return await FindAll().ToListAsync();
        }
        public async Task<IEnumerable<Comentario>> ObterTodos(int page, int quantity)
        {
            return await FindAll().Skip((page * quantity) - 1).ToListAsync();
        }
        public async Task<Comentario> ObterPorId(int id)
        {
            return await FindByCondition(x => x.Id.Equals(id))
            .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Comentario>> ObterTodosComentariosPorArtigo(int artigoId)
        {
            return await FindByCondition(comentario => comentario.ArtigoId.Equals(artigoId))
                .OrderByDescending(filtro => filtro.DataPublicacao)
                .ToListAsync();
                
        }

        public void Cadastrar(Comentario comentario)
        {
            Create(comentario);
        }
        public void Atualizar(Comentario comentario)
        {
            Update(comentario);
        }
        public void Remover(Comentario comentario)
        {
            Delete(comentario);
        }        
    }
}