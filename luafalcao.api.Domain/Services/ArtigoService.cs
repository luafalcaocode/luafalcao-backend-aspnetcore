using luafalcao.api.Domain.Contracts.Services;
using luafalcao.api.Persistence.Contracts.Repositories;
using luafalcao.api.Persistence.Entities;
using luafalcao.api.Shared.Enums;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace luafalcao.api.Domain.Services
{
    public class ArtigoService : IArtigoService
    {
        private IRepositoryManager repositorio;
        private IConfiguration configuration;

        public ArtigoService(IRepositoryManager repositorio, IConfiguration configuration)
        {
            this.repositorio = repositorio;
            this.configuration = configuration;
        }

        public async Task<int> ObterQuantidadeArtigosPorCategoria(BlogEnum blog)
        {
            return await this.repositorio.Artigo.ObterQuantidadeArtigosPorCategoria(blog);
        }

        public async Task Atualizar(Artigo artigo)
        {
            this.repositorio.Artigo.Atualizar(artigo);
            await this.repositorio.SaveAsync();
        }

        public async Task Cadastrar(Artigo artigo)
        {
            this.repositorio.Artigo.Cadastrar(artigo);
            await this.repositorio.SaveAsync();
        }

        public async Task<Artigo> ObterPorId(int id)
        {
            return await this.repositorio.Artigo.ObterPorId(id);
        }

        public async Task<IEnumerable<Artigo>> ObterTodos(int page, int quantity, BlogEnum blog)
        {
            return await CarregarCaminhosDasImagens(await this.repositorio.Artigo.ObterTodos(page, quantity, blog),
                ObterUrlBlog(blog));
        }

        public async Task<IEnumerable<Artigo>> ObterUltimasPublicacoes(BlogEnum blog)
        {
            return await CarregarCaminhosDasImagens(await this.repositorio.Artigo.ObterUltimasPublicacoes(blog), ObterUrlBlog(blog));
        }

        private async Task<IEnumerable<Artigo>> CarregarCaminhosDasImagens(IEnumerable<Artigo> artigos, string urlDoBlog)
        {
            await Task<IEnumerable<Artigo>>.Run(() =>
            {
                var caminho = this.configuration.GetSection("Assets").GetSection("blogs").Value;

                foreach (var artigo in artigos)
                {
                    artigo.Thumbnail = caminho.Replace("{nome_do_blog}", urlDoBlog)
                        .Replace("{id_do_post}", artigo.Id.ToString())
                        .Replace("{imagem}", "thumbnail")
                        .Replace("{extensao}", "jpg");
                }

                return artigos;                
            });

            return artigos;
        }

        

        private string ObterUrlBlog(BlogEnum blog)
        {
            switch(blog)
            {
                case BlogEnum.DiarioEngenheiroSoftware:
                    return "diario-de-um-engenheiro-de-software";
            }

            return null;
        }

        public async Task Remover(Artigo artigo)
        {
            this.repositorio.Artigo.Remover(artigo);
            await this.repositorio.SaveAsync();
        }
    }
}