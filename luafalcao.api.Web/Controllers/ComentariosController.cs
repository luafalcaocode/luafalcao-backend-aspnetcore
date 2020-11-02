using luafalcao.api.Facade;
using luafalcao.api.Facade.Contracts;
using luafalcao.api.Persistence.DataTransferObjects.Comentario;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace luafalcao.api.Web.Controllers
{
    [ApiController]
    [Route("api/v1/artigos/{artigoId}/comentarios")]
    public class ComentariosController : ControllerBase
    {
        private IBlogFacade facade;

        public ComentariosController(IBlogFacade facade)
        {
            this.facade = facade;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int artigoId)
        {
            var message = await this.facade.ObterComentariosPorArtigo(artigoId);
            return StatusCode(message.StatusCode, message);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ComentarioCadastroDto comentario)
        {
            var message = await this.facade.InserirComentario(comentario);
            return StatusCode(message.StatusCode, message);
        }
    }
}
