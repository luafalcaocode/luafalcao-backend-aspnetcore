using System.Threading.Tasks;
using luafalcao.api.Persistence.Contexts;
using luafalcao.api.Persistence.Contracts.Repositories;
using luafalcao.api.Persistence.Enums;
using luafalcao.api.Persistence.Factories;

namespace luafalcao.api.Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext context;

        private IArtigoRepository artigo;
        private IComentarioRepository comentario;

        public IArtigoRepository Artigo 
        {
            get 
            {
                if (this.artigo == null)
                {
                    this.artigo = RepositoryFactory.Create(RepositoryTypeEnum.Artigo, this.context);
                }

                return this.artigo;
            }
        }

        public IComentarioRepository Comentario 
        {
            get 
            {
                if (this.comentario == null)
                {
                    this.comentario = RepositoryFactory.Create(RepositoryTypeEnum.Comentario, this.context);
                }

                return this.comentario;
            }
        }

        public RepositoryManager(RepositoryContext context)
        {
            this.context = context;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
