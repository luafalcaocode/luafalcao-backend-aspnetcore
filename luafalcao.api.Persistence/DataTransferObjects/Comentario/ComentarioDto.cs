using System;
namespace luafalcao.api.Persistence.DataTransferObjects.Comentario
{
    public class ComentarioDto
    {
        public string Autor { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }

        public ComentarioDto()
        {
        }
    }
}
