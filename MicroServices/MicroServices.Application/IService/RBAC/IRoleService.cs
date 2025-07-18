using MicroServices.Models.Dtos.RBACDtos;
using MricoServices.Domain.RBAC;
using MricoServices.Shared.ApiResult;
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
        /// <summary>
        /// 获取角色列表信息
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<ApiPaging<List<RoleDto>>>> GetAllRolesAsync();
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="createUpdateRoleDto"></param>
        /// <returns></returns>
        Task<ApiResult> AddRoleAsync(CreateUpdateRoleDto createUpdateRoleDto);
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="createUpdateRoleDto"></param>
        /// <returns></returns>
        Task<ApiResult<RoleDto>> UpdateRoleAsync(int roleid,CreateUpdateRoleDto createUpdateRoleDto);
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        Task<ApiResult> DeleteRoleAsync(int roleId);
    }
}
