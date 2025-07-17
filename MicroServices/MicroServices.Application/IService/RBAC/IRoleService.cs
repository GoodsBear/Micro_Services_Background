using MricoServices.Domain.RBAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MricoServices.Application.IService.RBAC
{
    // Interfaces/IRoleService.cs
    public interface IRoleService
    {
        Task<Role> GetRoleByIdAsync(int roleId);
        Task<List<Role>> GetAllRolesAsync();
        Task AddRoleAsync(Role role);
        Task UpdateRoleAsync(Role role);
        Task DeleteRoleAsync(int roleId);
        Task AssignPermissionsToRoleAsync(int roleId, List<int> permissionIds);
        Task RemovePermissionsFromRoleAsync(int roleId, List<int> permissionIds);
    }
}
