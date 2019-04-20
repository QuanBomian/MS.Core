using System;
using System.Collections.Generic;
using AspNetCore.Entity;
using AspNetCore.Entity.Core;
namespace AspNetCore.Domain.UserRoleInfo
{
    public interface IUserRoleDomain : IDomain<UserRole, Guid>
    {
       
    }
}