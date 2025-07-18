using MricoServices.Shared;
using MricoServices.Shared.ApiResult;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Models.Dtos.RBACDtos
{
    /// <summary>
    /// 角色列表
    /// </summary>
    public class RoleDto : AuditableEntity
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
    /// <summary>
    /// 角色创建更新DTO
    /// </summary>
    public class CreateUpdateRoleDto
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
    /// <summary>
    /// 角色名进行查询DTO
    /// </summary>
    public class  SearchRoleDto: PageModel
    {
        public string? RoleName { get; set; }
    }
}
