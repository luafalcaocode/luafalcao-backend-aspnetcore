using System;
namespace luafalcao.api.Persistence.DataTransferObjects.Comentario
{
    public class ComentarioCadastroDto
    {
        public string Autor { get; set; }
        public string Descricao { get; set; }
        public string DataPublicacao { get; set; }
        public string Email { get; set; }

        public int ArtigoId { get; set; }

        public ComentarioCadastroDto()
        {
        }
    }
}
