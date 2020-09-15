using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace luafalcao.api.Persistence.Entities
{
    [Table("Artigo")]
    public class Artigo
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AQualBlogPertence {get;set;}

        public string Thumbnail { get; set; }
        
        public DateTime DataPublicacao { get; set; }
        public string[] Tags { get; set; }
        public int NumeroLikes { get; set; }
        

        public ICollection<Comentario> Comentarios { get; set; }
    }
}