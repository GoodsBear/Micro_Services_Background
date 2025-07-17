using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MricoServices.Application.IService.RBAC;
using MricoServices.Models.Dtos;
using MricoServices.Shared.ApiResult;

namespace MicroService.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        /// <summary>
        /// 用户添加
        /// </summary>
        /// <param name="createUpdateUserDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ApiResult<UserDto>> CreateUserAsync(CreateUpdateUserDto createUpdateUserDto)
        {
            return await userService.CreateUserAsync(createUpdateUserDto);
        }
    }
}
