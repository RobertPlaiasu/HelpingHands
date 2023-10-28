using AutoMapper;
using HelpingHands.Dtos;
using HelpingHands.Entities;

namespace HelpingHands
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            
            CreateMap<User, GetUserDto>();
            /*
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            */
        }
    }
}
