using System;
namespace luafalcao.api.Persistence.DataTransferObjects.Comentario
{
    public class ComentarioDto
    {
        public string Autor { get; set; }
        public string Descricao { get; set; }
        public string DataPublicacao { get; set; }

        public ComentarioDto()
        {
        }
    }
}
