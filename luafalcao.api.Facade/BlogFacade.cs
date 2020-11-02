using AutoMapper;
using luafalcao.api.Domain.Contracts.Services;
using luafalcao.api.Facade.Contracts;
using luafalcao.api.Persistence.DataTransferObjects.Artigo;
using luafalcao.api.Persistence.DataTransferObjects.Comentario;
using luafalcao.api.Persistence.Entities;
using luafalcao.api.Shared.Enums;
using luafalcao.api.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace luafalcao.api.Facade
{
    public class BlogFacade : IBlogFacade
    {
        private IMapper mapper;
        private IArtigoService artigoService;
        private IComentarioService comentarioService;

        public BlogFacade(IArtigoService artigoService, IComentarioService comentarioService, IMapper mapper)
        {
            this.artigoService = artigoService;
            this.comentarioService = comentarioService;
            this.mapper = mapper;
        }

        public async Task<Message<int>> ObterQuantidadeArtigosPorCategoria(BlogEnum blog)
        {
            var message = new Message<int>();

            try
            {
                message.Ok(await this.artigoService.ObterQuantidadeArtigosPorCategoria(blog));
            }
            catch(Exception exception)
            {
                message.Error(exception);
            }

            return message;
        }

        public async Task<Message<IEnumerable<ArtigoDto>>> ObterArtigosPaginados(int page, int quantity, BlogEnum blog)
        {
            var message = new Message<IEnumerable<ArtigoDto>>();

            try
            {
                var artigos = this.mapper.Map<IEnumerable<ArtigoDto>>(await this.artigoService.ObterTodos(page, quantity, blog));
                if (!artigos.Any())
                {
                    message.NotFound();
                }

                message.Ok(artigos);

            }
            catch (Exception exception)
            {
                message.Error(exception);
            }

            return message;
        }

        public async Task<Message<ArtigoDto>> ObterArtigoPorId(int id)
        {
            var message = new Message<ArtigoDto>();

            try 
            {
                var artigo = this.mapper.Map<ArtigoDto>(await this.artigoService.ObterPorId(id));
                if (artigo == null)
                {
                    message.NotFound();
                }

                message.Ok(artigo);
            }
            catch(Exception exception)
            {
                message.Error(exception);
            }

            return message;
        }

        public async Task<Message<IEnumerable<ArtigoDto>>> ObterUltimasPublicacoes(BlogEnum blog)
        {
            var message = new Message<IEnumerable<ArtigoDto>>();

            try
            {
                var ultimasPublicacoes = this.mapper.Map<IEnumerable<ArtigoDto>>(await this.artigoService.ObterUltimasPublicacoes(blog));
                if (!ultimasPublicacoes.Any())
                {
                    message.NotFound();

                    return message;
                }

                message.Ok(ultimasPublicacoes);

            }
            catch(Exception exception)
            {
                message.Error(exception);
            }

            return message;
        }

        public async Task<Message<IEnumerable<ComentarioDto>>> ObterComentariosPorArtigo(int artigoId)
        {
            var message = new Message<IEnumerable<ComentarioDto>>();

            try
            {
                var artigo = this.mapper.Map<ArtigoDto>(await this.artigoService.ObterPorId(artigoId));
                if (artigo == null)
                {
                    message.NotFound();
                }

                var comentarios = this.mapper.Map<IEnumerable<ComentarioDto>>(await this.comentarioService.ObterTodosComentariosPorArtigo(artigoId));
                if (comentarios == null)
                {
                    message.NotFound();
                }

                message.Ok(comentarios);
            }
            catch(Exception exception)
            {
                message.Error(exception);
            }

            return message;
        }

        public async Task<Message> InserirComentario(ComentarioCadastroDto comentario)
        {
            var message = new Message();

            try
            {
                await this.comentarioService.Cadastrar(this.mapper.Map<Comentario>(comentario));
                message.Ok();
            }
            catch(Exception exception)
            {
                message.Error(exception);
            }

            return message;
        }
     }
}