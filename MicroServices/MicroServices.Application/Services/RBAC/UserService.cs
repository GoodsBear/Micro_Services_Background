using AutoMapper;
using MicroServices.Repository.IRepository.I_RBAC_Repository;
using MricoServices.Application.IService.RBAC;
using MricoServices.Domain.RBAC;
using MricoServices.Models.Dtos;
using MricoServices.Shared.ApiResult;

namespace MricoServices.Application.Services.RBAC
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository _userRepository,IMapper mapper)
        {
            userRepository = _userRepository;
            this.mapper = mapper;
        }

        /// <summary>
        /// 创建新用户 (业务逻辑的骨架)
        /// </summary>
        /// <param name="request">包含用户创建信息的请求DTO</param>
        /// <returns>操作结果</returns>
        public async Task<ApiResult<UserDto>> CreateUserAsync(CreateUpdateUserDto createUpdateUserDto)
        {
            try
            {
                var list = await userRepository.AddAsync(mapper.Map<User>(createUpdateUserDto));

                return list > 0
                    ? ApiResult<UserDto>.Success(ResultCode.Ok,mapper.Map<UserDto>(createUpdateUserDto))
                    : ApiResult<UserDto>.Fail(ResultCode.Fail,"创建失败");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
