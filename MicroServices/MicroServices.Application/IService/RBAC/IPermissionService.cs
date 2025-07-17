using MricoServices.Domain.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MricoServices.Application.IService.RBAC
{
    // Interfaces/IPermissionService.cs
    public interface IPermissionService
    {
        Task<Permission> GetPermissionByIdAsync(int permissionId);
        Task<List<Permission>> GetAllPermissionsAsync();
        Task AddPermissionAsync(Permission permission);
        Task UpdatePermissionAsync(Permission permission);
        Task DeletePermissionAsync(int permissionId);
    }
}
