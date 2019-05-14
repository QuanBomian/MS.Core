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
        User GetUserForLogin(string account, string password);
    }
}