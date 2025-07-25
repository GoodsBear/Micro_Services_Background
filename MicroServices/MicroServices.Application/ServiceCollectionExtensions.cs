using MicroServices.Application.IService.Houses;
using MicroServices.Application.IService.StorgeServices;
using MicroServices.Application.Services.House;
using MicroServices.Application.Services.StorgeService;
using MicroServices.Repository.IRepository.IInventory;
using MicroServices.Repository.Repository;
using MicroServices.Repository.Repository.Inventorys;
using Microsoft.Extensions.DependencyInjection;
using MricoServices.Application.IService.RBAC;
using MricoServices.Application.MapperProFiles;
using MricoServices.Application.Services.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            // 注册 AutoMapper
            services.AddAutoMapper(typeof(MapperProFiles));

            // 注册应用层服务
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
			// services.AddScoped<IMenuService, MenuService>();
			// services.AddScoped<IPermissionService, PermissionService>();

            //注册仓库相关服务
			services.AddScoped<IWareHouseService, WareHouseService>();
			services.AddScoped<IHouseAreaService, HouseAreaService>();
			services.AddScoped<IHouseLocationService, HouseLocationService>();

			//注册出入库相关服务
			services.AddScoped<IProductStorgeService, ProductStorgeService>();
            services.AddScoped<IMaterialInventoryRepository, MaterialInventoryRepository>();
            services.AddScoped<IProductInventoryRepository, ProductInventoryRepository>();


			return services;
        }
    }
}
