using AutoMapper;
using Core.Models;
using WebApi.Dtos;

namespace WebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Crab, CrabDto>();
        }
    }
}
