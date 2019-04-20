using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Domain.Repository;
using AspNetCore.Domain.UserRoleInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.UserRoleInfo
{
    public class UserRoleDomain : Domain<UserRole, Guid>, IUserRoleDomain
    {

        public UserRoleDomain(IUserRoleRepository repository) : base(repository) { }
  


    }
}
