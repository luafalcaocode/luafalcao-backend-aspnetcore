using luafalcao.api.Persistence.Contracts.Repositories;
using luafalcao.api.Persistence.Entities;
using luafalcao.api.Persistence.Contexts;

using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using System.Linq;
using luafalcao.api.Shared.Enums;
using System;

namespace luafalcao.api.Persistence.Repositories
{
    public class ArtigoRepository : RepositoryBase<Artigo>, IArtigoRepository
    {
        public ArtigoRepository(RepositoryContext context) : base(context)
        {

        }

        public async Task<int> ObterQuantidadeArtigosPorCategoria(BlogEnum blog)
        {
            return await FindAll()
                .CountAsync();
        }

        public async Task<IEnumerable<Artigo>> ObterTodos(int page, int quantity, BlogEnum blog)
        {
            return await FindAll()
                .Where(filtro => filtro.AQualBlogPertence.Equals(Convert.ToString((int) blog)))
                .OrderByDescending(filtro => filtro.DataPublicacao)
                .Skip((page - 1 ) * quantity)
                .Take(quantity)
                .ToListAsync();
        }

        public async Task<IEnumerable<Artigo>> ObterUltimasPublicacoes(BlogEnum blog)
        {
            return await FindAll()
                .Where(filtro => filtro.AQualBlogPertence.Equals(blog.ToString()))
                .Take(5)
                .ToListAsync();
        }

        public async Task<IEnumerable<Artigo>> ObterTodos()
        {
            return await FindAll().ToListAsync();
        }
        public async Task<Artigo> ObterPorId(int id)
        {
            return await FindByCondition(x => x.Id.Equals(id))
                .OrderByDescending(x => x.DataPublicacao)
                .FirstOrDefaultAsync();
        }
        public void Cadastrar(Artigo artigo)
        {
            Create(artigo);
        }
        public void Atualizar(Artigo artigo)
        {
            Update(artigo);
        }
        public void Remover(Artigo artigo)
        {
            Remover(artigo);
        }        
    }
}