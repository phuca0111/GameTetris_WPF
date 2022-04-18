
using AutoMapper;
using TetrisAPI.Dtos;
using TetrisAPI.Models;

namespace TetrisAPI.Profiles
{
    public class TetrisProfile : Profile
    {
        public TetrisProfile()
        {
            // Source -> Target
            CreateMap<TetrisDtos,TetrisCore>()
                .ForMember(dest=>dest.NamePlayer,act=>act.MapFrom(src=>src.NamePlayer))
                .ForMember(dest=>dest.Score,act=>act.MapFrom(src=>src.Score));

            CreateMap<TetrisCore,TetrisReadDtos>();
        }
    }
}