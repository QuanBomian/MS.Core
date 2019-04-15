using System;
using System.Collections.Generic;
using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity.Core;
using AspNetCore.Entity;
namespace AspNetCore.Domain.UserInfo
{

    public interface IUserDomain : IDomain<User, Guid>
    {
        List<User> Get(UserQueryDto queryDto);
    }
}