using luafalcao.api.Facade.Contracts;
using luafalcao.api.Persistence.DataTransferObjects.Artigo;
using luafalcao.api.Shared.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using System.Threading.Tasks;

namespace luafalcao.api.Web.Controllers
{
    [ApiController]
    [Route("api/v1/artigos")]
    public class ArtigosController : ControllerBase
    {
        private IBlogFacade facade;

        public ArtigosController(IBlogFacade facade)
        {
            this.facade = facade;
        }

        [HttpGet]
        [Route("quantidade")]
        public async Task<IActionResult> GetCountPorCategoria(BlogEnum blog)
        {
            var message = await this.facade.ObterQuantidadeArtigosPorCategoria(blog);
            return StatusCode(message.StatusCode, message);
        }

        [HttpGet]
        public async Task<IActionResult> Get(BlogEnum blog, int pagina, int quantidade)
        {
            var message = await this.facade.ObterArtigosPaginados(pagina, quantidade, blog);
            return StatusCode(message.StatusCode, message);
        }

        [HttpGet]
        [Route("destaques")]
        public async Task<IActionResult> GetUltimasPublicacoes(BlogEnum blog)
        {
            var message = await this.facade.ObterUltimasPublicacoes(blog);
            return StatusCode(message.StatusCode, message);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var message = await this.facade.ObterArtigoPorId(id);
            return StatusCode(message.StatusCode, message);
        }

        [HttpPut]
        [Route("{id}/like")]
        public async Task<IActionResult> Like(ArtigoDto artigo)
        {
            var message = await this.facade.AddLike(artigo);
            return StatusCode(message.StatusCode, message);
        }
    }
}