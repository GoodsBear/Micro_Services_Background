using MicroServices.Application.IService.ProcessInfo;
using MicroServices.Application.Services.ProcessInfo;
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
            services.AddScoped<IProcessService, ProcessService>();
            services.AddScoped<IProcessCompositionService, ProcessCompositionService>();
            services.AddScoped<IProcessRouteService, ProcessRouteService>();

            return services;
        }
    }
}
