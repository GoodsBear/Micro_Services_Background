using AutoMapper;
using MricoServices.Domain.RBAC;
using MricoServices.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MricoServices.Application.MapperProFiles
{
    public class MapperProFiles:Profile
    {
        public MapperProFiles()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<CreateUpdateUserDto, UserDto>().ReverseMap();
            CreateMap<CreateUpdateUserDto, User>().ReverseMap();
        }
    }
}
