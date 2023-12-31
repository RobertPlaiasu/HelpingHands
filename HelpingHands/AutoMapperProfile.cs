﻿using AutoMapper;
using HelpingHands.Dtos;
using HelpingHands.Entities;

namespace HelpingHands
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Ong, GetOngDto>();
            CreateMap<Ong, GetOngDetailsDto>();
            CreateMap<User, GetUserDto>();
            CreateMap<CreatePostDto, Post>();
            CreateMap<PostNeedDto, Need>();
            CreateMap<StoreOngDto, Ong>();
            /*
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            */
        }


    }
}
