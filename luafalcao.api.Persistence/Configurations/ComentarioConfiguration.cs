using luafalcao.api.Persistence.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using luafalcao.api.Shared.Enums;

namespace luafalcao.api.Persistence.Configurations
{
    public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.HasData(new Comentario
            {
                Id = 1,
                Autor = "Luã Falcão",
                DataPublicacao = DateTime.Now,
                Descricao = "Comentário.......",
                Email = "lpjfalcao@gmail.com",
                ArtigoId = 1                
            },
            new Comentario
            {
                Id = 2,
                Autor = "Luã Falcão",
                DataPublicacao = DateTime.Now,
                Descricao = "Comentário.......",
                Email = "lpjfalcao@gmail.com",
                ArtigoId = 2
            });
        }
    }
}