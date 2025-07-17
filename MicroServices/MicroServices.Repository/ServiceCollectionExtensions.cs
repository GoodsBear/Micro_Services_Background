using MicroServices.Repository.IRepository.I_RBAC_Repository;
using MicroServices.Repository.Repository.RBAC_Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Repository
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
        {
            // 注册仓储服务
            services.AddScoped<IUserRepository, UserRepository>();
            // 添加其他仓储接口和实现的注册

            return services;
        }

    }
}
