using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace luafalcao.api.Persistence.Entities
{
    [Table("Comentario")]
    public class Comentario : IEntity
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Email { get; set; }

        [ForeignKey(nameof(Artigo))]
        public int ArtigoId { get; set; }
        public Artigo Artigo { get; set; }
    }
}