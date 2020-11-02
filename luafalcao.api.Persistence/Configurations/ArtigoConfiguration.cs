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
    public class ArtigoConfiguration : IEntityTypeConfiguration<Artigo>
    {
        public void Configure(EntityTypeBuilder<Artigo> builder)
        {
            builder.HasData(new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(1),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 1",
                Id = 1,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(2),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programção" },
                Titulo = "Artigo 2",
                Id = 2,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(3),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 3",
                Id = 3,
                NumeroLikes = 5,
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(4),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 4",
                Id = 4,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(5),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 5",
                Id = 5,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(6),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 6",
                Id = 6,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(7),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 7",
                Id = 7,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(8),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 8",
                Id = 8,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(9),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 9",
                Id = 9,
                NumeroLikes = 5,
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(10),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 10",
                Id = 10,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(11),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 11",
                Id = 11,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(12),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 12",
                Id = 12,
                NumeroLikes = 5,
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(13),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 13",
                Id = 13,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(14),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 14",
                Id = 14,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(15),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 15",
                Id = 15,
                NumeroLikes = 5
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(16),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 16",
                Id = 16,
                NumeroLikes = 5,
            },
            new Artigo
            {
                AQualBlogPertence = BlogEnum.DiarioEngenheiroSoftware.ToString(),
                DataPublicacao = DateTime.Now.AddDays(17),
                Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vulputate non purus ac ultricies. In et lectus leo. Suspendisse ornare augue nisl, sed bibendum eros tempus eu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam semper, ante id fermentum egestas, magna libero ultrices justo, id mollis felis ante et elit..",
                Tags = new string[] { "Engenharia de Software", "Design Patterns", "Programação" },
                Titulo = "Artigo 17",
                Id = 17,
                NumeroLikes = 5,
            });
        }
    }

}