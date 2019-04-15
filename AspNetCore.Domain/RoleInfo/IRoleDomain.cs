using System;
using System.Collections.Generic;
using AspNetCore.Domain.RoleInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Entity.Core;
namespace AspNetCore.Domain.RoleInfo
{
    public interface IRoleDomain : IDomain<Role, Guid>
    {
        List<Role> Get(RoleQueryDto queryDto);
    }
}