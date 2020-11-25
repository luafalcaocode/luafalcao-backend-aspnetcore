using luafalcao.api.Domain.Contracts.Services;
using luafalcao.api.Domain.Singletons.Validations;
using luafalcao.api.Persistence.Contracts.Repositories;
using luafalcao.api.Persistence.Entities;


using System.Globalization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System;
using luafalcao.api.Shared.Utils;

namespace luafalcao.api.Domain.Services
{
    public class ComentarioService : IComentarioService
    {
        private IRepositoryManager repositorio;

        public ComentarioService(IRepositoryManager repositorio)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            this.repositorio = repositorio;
        }

        public async Task Atualizar(Comentario comentario)
        {
            this.repositorio.Comentario.Atualizar(comentario);
            await this.repositorio.SaveAsync();
        }

        public async Task Cadastrar(Comentario comentario)
        {                
            this.repositorio.Comentario.Cadastrar(comentario);
            await this.repositorio.SaveAsync();
        }

        public async Task<Comentario> ObterPorId(int id)
        {
            return await this.repositorio.Comentario.ObterPorId(id);
        }

        public async Task<IEnumerable<Comentario>> ObterTodos()
        {
            return await this.repositorio.Comentario.ObterTodos();
        }

        public async Task<IEnumerable<Comentario>> ObterTodosComentariosPorArtigo(int artigoId)
        {
            return await this.repositorio.Comentario.ObterTodosComentariosPorArtigo(artigoId);
        }

        public async Task<IEnumerable<Comentario>> ObterTodos(int page, int quantity)
        {
            return await this.repositorio.Comentario.ObterTodos(page, quantity);
        }

        public async Task Remover(Comentario comentario)
        {
            this.repositorio.Comentario.Remover(comentario);
            await this.repositorio.SaveAsync();
        }        
    }
}