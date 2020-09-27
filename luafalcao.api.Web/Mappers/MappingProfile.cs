using AutoMapper;
using luafalcao.api.Persistence.DataTransferObjects.Artigo;
using luafalcao.api.Persistence.Entities;
using luafalcao.api.Shared.Utils;

namespace luafalcao.api.Web.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            MapArtigo();
            CreateMap(typeof(Message<>), typeof(Message<>));
        }

        public void MapArtigo()
        {
            CreateMap<Artigo, ArtigoDto>()
                .ForMember(artigoDto => artigoDto.DataPublicacao, options => options.MapFrom(artigo => artigo.DataPublicacao.ToLongDateString()));
        }
    }
}
