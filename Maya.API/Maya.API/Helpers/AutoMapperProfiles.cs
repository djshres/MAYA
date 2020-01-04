﻿using AutoMapper;
using Maya.API.Dtos;
using Maya.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maya.API.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt =>
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age, opt =>
                   opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailDto>()
                 .ForMember(dest => dest.PhotoUrl, opt =>
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                  .ForMember(dest => dest.Age, opt =>
                   opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotosForDetailDto>();
            CreateMap<UserForUpdateDto, User>();
        }
    }
}
