using MicroServices.Repository.IRepository.I_RBAC_Repository;
using MricoServices.Domain.RBAC;
using MricoServices.Models.Dtos;
using MricoServices.Repository.Repository;
using MricoServices.Shared.ApiResult;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Repository.Repository.RBAC_Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ISqlSugarClient db) : base(db)
        {
            // BaseRepository 的构造函数已经设置了 base.Context = db;
            // 所以这里不需要额外的操作
        }

        public Task<ApiResult<UserDto>> Login(string userName, string userPwd)
        {
            throw new NotImplementedException();
        }

        ///// <summary>
        ///// 根据用户名获取用户（通常用于登录验证）
        ///// </summary>
        ///// <param name="username">用户名</param>
        ///// <returns>用户实体，如果不存在则返回 null</returns>
        //public async Task<User> GetUserByUsernameAsync(string username)
        //{
        //    return await Context.Queryable<User>()
        //                                   .Includes<UserRole>(u => u.UserRoles) // 显式指定 UserRole
        //                                   //.ThenIncludes<Role>(ur => ur.Role)   // 显式指定 Role
        //                                   .FirstAsync(u => u.Username == username && !u.IsDeleted);
        //}

        //public async Task<User> GetUserWithRolesAsync(int userId)
        //{
        //    return await Context.Queryable<User>()
        //                        .Includes(u => u.UserRoles)
        //                        //.ThenIncludes(ur => ur.Role)
        //                        .FirstAsync(u => u.Id == userId && !u.IsDeleted);
        //}

        //public async Task<ApiPaging<List<User>>> GetPagedUsersWithRolesAsync(UserSearch search)
        //{
        //    var query = Context.Queryable<User>()
        //                       .Includes(u => u.UserRoles)
        //                       //.ThenIncludes(ur => ur.Role)
        //                       .Where(u => !u.IsDeleted);

        //    if (!string.IsNullOrWhiteSpace(search.Username))
        //    {
        //        query = query.Where(u => u.Username.Contains(search.Username));
        //    }
        //    if (!string.IsNullOrWhiteSpace(search.Email))
        //    {
        //        query = query.Where(u => u.Email.Contains(search.Email));
        //    }
        //    //if (search.IsActive.HasValue)
        //    //{
        //    //    query = query.Where(u => u.IsActive == search.IsActive.Value);
        //    //}

        //    query = query.OrderBy(u => u.Id, OrderByType.Desc);

        //    var totalCount = 0;
        //    var list = await query.ToPageListAsync(search.PageIndex, search.PageSize, RefAsync.Create(totalCount));

        //    var totalPages = (int)Math.Ceiling(totalCount / (double)search.PageSize);

        //    return new ApiPaging<List<User>>
        //    {
        //        Data = list,
        //        TotleCount = totalCount,
        //        TotlePage = totalPages
        //    };
        //}

        //public async Task<bool> IsUsernameExistAsync(string username, int? excludeId = null)
        //{
        //    var query = Context.Queryable<User>().Where(u => u.Username == username && !u.IsDeleted);
        //    if (excludeId.HasValue)
        //    {
        //        query = query.Where(u => u.Id != excludeId.Value);
        //    }
        //    return await query.AnyAsync();
        //}

        //public async Task<bool> IsEmailExistAsync(string email, int? excludeId = null)
        //{
        //    if (string.IsNullOrWhiteSpace(email)) return false;
        //    var query = Context.Queryable<User>().Where(u => u.Email == email && !u.IsDeleted);
        //    if (excludeId.HasValue)
        //    {
        //        query = query.Where(u => u.Id != excludeId.Value);
        //    }
        //    return await query.AnyAsync();
        //}
    }
}
