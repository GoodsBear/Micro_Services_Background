using MicroServices.Repository.IRepository.I_RBAC_Repository;
using MicroServices.Repository.Repository.RBAC_Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MricoServices.Domain.RBAC; 
using MricoServices.Infrastructure.Data;
using MricoServices.Repository.IRepository;
using MricoServices.Repository.Repository;
using MricoServices.Shared;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // 注册 SqlSugar 客户端
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("DefaultConnection string is not configured in appsettings.json.");
            }

            services.AddSingleton<ISqlSugarClient>(provider =>
            {
                return SqlSugarSetup.GetSqlSugarClient(connectionString, DbType.PostgreSQL);
            });

            // 注册仓储服务
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUserRepository, MicroServices.Repository.Repository.RBAC_Repository.UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();

            return services;
        }
    }
}
