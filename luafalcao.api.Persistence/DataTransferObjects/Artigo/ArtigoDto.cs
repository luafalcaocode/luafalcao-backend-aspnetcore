using System;

namespace luafalcao.api.Persistence.DataTransferObjects.Artigo
{
    public class ArtigoDto
    {
        public int Id {get;set;}
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Thumbnail { get; set; }
        public string AQualBlogPertence {get;set;}
        public string DataPublicacao { get; set; }
        public string[] Tags { get; set; }
        public int NumeroLikes { get; set; }
        
    }
}