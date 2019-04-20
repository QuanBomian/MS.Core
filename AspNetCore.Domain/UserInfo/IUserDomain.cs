using System;
using System.Collections.Generic;
using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity.Core;
using AspNetCore.Entity;
using System.Threading.Tasks;

namespace AspNetCore.Domain.UserInfo
{

    public interface IUserDomain : IDomain<User, Guid>
    {
        List<User> Get(UserQueryDto queryDto);
        Task<User> GetUserForLoginAsync(string account, string password);
    }
}