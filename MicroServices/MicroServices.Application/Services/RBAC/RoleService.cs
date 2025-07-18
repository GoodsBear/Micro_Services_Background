using AutoMapper;
using MicroServices.Models.Dtos.RBACDtos;
using MicroServices.Repository.IRepository.I_RBAC_Repository;
using MicroServices.Repository.Repository.RBAC_Repository;
using MricoServices.Application.IService.RBAC;
using MricoServices.Domain.RBAC;
using MricoServices.Shared.ApiResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MricoServices.Application.Services.RBAC
{
    public class RoleService : IRoleService
    {
        private readonly IUserRepository userRepository;
        private readonly IRoleRepository roleRepository;
        private readonly IMapper mapper;

        public RoleService(IRoleRepository roleRepository,IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }

        /// <summary>
        /// 角色添加
        /// </summary>
        /// <param name="createUpdateRoleDto"></param>
        /// <returns></returns>
        public async Task<ApiResult> AddRoleAsync(CreateUpdateRoleDto createUpdateRoleDto)
        {
            try
            {
                var list = await roleRepository.GetAll().Where(d => d.RoleName == createUpdateRoleDto.RoleName).AnyAsync();
                if(list)
                {
                    return ApiResult.Fail(ResultCode.Fail, "该角色名称已存在");
                }
                var result = await roleRepository.AddAsync(mapper.Map<Role>(createUpdateRoleDto));
                return result > 0 
                    ? ApiResult.Success(ResultCode.Ok) 
                    : ApiResult.Fail(ResultCode.Fail, "角色添加失败");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        /// <summary>
        /// 角色软删除
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public async Task<ApiResult> DeleteRoleAsync(int roleId)
        {
            try
            {
                var list = await roleRepository.GetAll().Where(d => d.Id == roleId).AnyAsync();
                if(!list)
                {
                    return ApiResult.Fail(ResultCode.Fail, "该角色不存在");
                }
                var result = await roleRepository.SoftDeleteAsync(roleId);
                return result>0
                    ? ApiResult.Success(ResultCode.Ok) 
                    : ApiResult.Fail(ResultCode.Fail, "角色删除失败");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Task<ApiResult<ApiPaging<List<RoleDto>>>> GetAllRolesAsync()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 角色修改
        /// </summary>
        /// <param name="createUpdateRoleDto"></param>
        /// <returns></returns>
        public async Task<ApiResult<RoleDto>> UpdateRoleAsync(int roleid,CreateUpdateRoleDto createUpdateRoleDto)
        {
            try
            {
                var role = await roleRepository.GetByIdAsync(roleid);
                if(role==null)
                {
                    return ApiResult<RoleDto>.Fail(ResultCode.Fail, "该角色不存在");
                }

                var result = mapper.Map(createUpdateRoleDto, role);


                var updateSuccess = await roleRepository.UpdateAsync(result);

                return updateSuccess > 0 
                    ? ApiResult<RoleDto>.Success(ResultCode.Ok, mapper.Map<RoleDto>(result)) 
                    : ApiResult<RoleDto>.Fail(ResultCode.Fail, "角色更新失败");
                

            }
            catch (Exception ex)
            {
                // 捕获并记录异常，然后返回一个通用的错误信息
                Console.WriteLine($"更新角色时发生异常: {ex.Message}");
                return ApiResult<RoleDto>.Fail(ResultCode.Fail, "更新角色时发生内部错误。");
            }
        }
    }
}
