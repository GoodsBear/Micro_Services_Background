using AutoMapper;
using MicroServices.Models.Dtos.RBACDtos;
using MricoServices.Domain.RBAC;
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

            CreateMap<RoleDto, Role>().ReverseMap();
            CreateMap<CreateUpdateRoleDto, RoleDto>().ReverseMap();
            CreateMap<CreateUpdateRoleDto, Role>().ReverseMap();


            CreateMap<PermissionDto, Permission>().ReverseMap();
            CreateMap<CreateUpdatePermissionDto, PermissionDto>().ReverseMap();
            CreateMap<CreateUpdatePermissionDto, Permission>().ReverseMap();


            CreateMap<MenuDto, Menu>().ReverseMap();
            CreateMap<CreateUpdateMenuDto, MenuDto>().ReverseMap();
            CreateMap<CreateUpdateMenuDto, Menu>().ReverseMap();
        }
    }
}
