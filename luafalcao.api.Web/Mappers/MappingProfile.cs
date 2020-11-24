using System.Collections.Generic;
using AutoMapper;
using luafalcao.api.Persistence.DataTransferObjects.Artigo;
using luafalcao.api.Persistence.DataTransferObjects.Comentario;
using luafalcao.api.Persistence.Entities;
using luafalcao.api.Shared.Utils;
using System.Threading;
using System.Globalization;

namespace luafalcao.api.Web.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            MapArtigo();
            MapComentario();
            CreateMap(typeof(Message<>), typeof(Message<>));
        }

        public void MapArtigo()
        {
            CreateMap<Artigo, ArtigoDto>()
                .ForMember(artigoDto => artigoDto.DataPublicacao, options => options.MapFrom(artigo => artigo.DataPublicacao.ToLongDateString()));           
        }

        public void MapComentario()
        {      
            CreateMap<Comentario, ComentarioDto>()
                   .ForMember(comentarioDto => comentarioDto.DataPublicacao, options => options.MapFrom(comentario => comentario.DataPublicacao.ToLongDateString()));

            CreateMap<ComentarioCadastroDto, Comentario>();
                        
        }
    }
}
