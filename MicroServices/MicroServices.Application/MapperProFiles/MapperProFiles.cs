using AutoMapper;
using MicroServices.Domain.InStorage;
using MicroServices.Models.Dtos.House;
using MicroServices.Models.Dtos.RBACDtos;
using MicroServices.Models.Dtos.StorgeDTOS;
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

		#region 仓库相关Dto
			//仓库相关Dto
			CreateMap<WareHouseDto, WareHouse>().ReverseMap();
            CreateMap<CreateUpdateWareHouseDto, WareHouseDto>().ReverseMap();
            CreateMap<CreateUpdateWareHouseDto, WareHouse>().ReverseMap();
            //库区相关Dto
			CreateMap<WareHouseAreaDto, WareHouseArea>().ReverseMap();
			CreateMap<CreateUpdateWareHouseAreaDto, WareHouseAreaDto>().ReverseMap();
			CreateMap<CreateUpdateWareHouseAreaDto, WareHouseArea>().ReverseMap();
            //库位相关Dto
			CreateMap<HouseLocationDto, WareHouseLocation>().ReverseMap();
			CreateMap<CreateUpdateHouseLocationDto, HouseLocationDto>().ReverseMap();
			CreateMap<CreateUpdateHouseLocationDto, WareHouseLocation>().ReverseMap();
			//入库单相关Dto
			CreateMap<ProductStorgeDto, ProductStorage>().ReverseMap();
			CreateMap<CreateUpdateProductStorgeDto, ProductStorgeDto>().ReverseMap();
			CreateMap<CreateUpdateProductStorgeDto, ProductStorage>().ReverseMap();
			//入库明细相关Dto
            CreateMap<ProductStorgeDetailDto, ProductStorageDetail>().ReverseMap();
            CreateMap<CreateUpdateProductStorgeDetailDto, ProductStorgeDetailDto>().ReverseMap();
            CreateMap<CreateUpdateProductStorgeDetailDto, ProductStorageDetail>().ReverseMap();
            //产品库存相关Dto
            CreateMap<ProductInventoryDto, ProductInventory>().ReverseMap();
            CreateMap<CreateUpdateProductInventoryDto, ProductInventoryDto>().ReverseMap();
            CreateMap<CreateUpdateProductInventoryDto, ProductInventory>().ReverseMap();

		#endregion
		}
	}
}
