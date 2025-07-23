using AutoMapper;
using MicroServices.Domain.InStorage;
using MicroServices.Models.Dtos.House;
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


            CreateMap<WareHouseDto, WareHouse>().ReverseMap();
            CreateMap<CreateUpdateWareHouseDto, WareHouseDto>().ReverseMap();
            CreateMap<CreateUpdateWareHouseDto, WareHouse>().ReverseMap();

			CreateMap<WareHouseAreaDto, WareHouseArea>().ReverseMap();
			CreateMap<CreateUpdateWareHouseAreaDto, WareHouseAreaDto>().ReverseMap();
			CreateMap<CreateUpdateWareHouseAreaDto, WareHouseArea>().ReverseMap();

			CreateMap<HouseLocationDto, WareHouseLocation>().ReverseMap();
			CreateMap<CreateUpdateHouseLocationDto, HouseLocationDto>().ReverseMap();
			CreateMap<CreateUpdateHouseLocationDto, WareHouseLocation>().ReverseMap();

		}
    }
}
