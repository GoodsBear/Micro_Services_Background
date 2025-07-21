using AutoMapper;
using MicroServices.Models.Dtos.RBACDtos;
using MicroServices.Repository.IRepository.I_RBAC_Repository;
using MricoServices.Application.IService.RBAC;
using MricoServices.Domain.RBAC;
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
        /// 登录获取用户信息
        /// </summary>
        /// <param name="userLoginDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<ApiResult> AuthenticateUserAsync(UserLoginDto userLoginDto)
        {
            // 1. 基本输入验证 (Service 层做更严格的DTO验证，但这里可以精简)
            if (userLoginDto == null || string.IsNullOrWhiteSpace(userLoginDto.LoginName) || string.IsNullOrWhiteSpace(userLoginDto.LoginPwd))
            {
                return ApiResult.Fail(ResultCode.Fail, "用户名或密码不能为空。");
            }
            try
            {
                // 2. 调用 UserRepository 进行登录验证
                var list = await userRepository.UserLogin(userLoginDto);

                // 3. 检查 UserRepository 返回的结果
                if (!list.IsSuc)
                {
                    // 如果 UserRepository 认证失败，则直接返回其失败信息
                    return ApiResult.Fail(list.code, list.msg);
                }
                // 4. 如果 UserRepository 认证成功，则获取用户信息
                var userDto = list.data;
                if (userDto == null) // 这是一种防御性检查，理论上 authResult.Data 在 IsSuccess 为 true 时不应为 null
                {
                    return ApiResult.Fail(ResultCode.Fail, "登录成功但获取用户信息失败。");
                }

                return ApiResult.Success(ResultCode.Ok); // 返回成功结果和用户信息
            }
            catch (Exception ex)
            {
                // 记录 Service 层可能发生的任何异常
                Console.WriteLine($"UserService.AuthenticateUserAsync 发生异常: {ex.Message}");
                return ApiResult.Fail(ResultCode.Fail, "登录过程中发生系统错误，请稍后再试。"); // 使用一个更通用的错误码
            }
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
