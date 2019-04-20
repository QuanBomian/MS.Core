using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Domain.Repository;
using AspNetCore.Domain.RoleInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.RoleInfo
{
    public class RoleDomain : Domain<Role, Guid>, IRoleDomain
    {

        public RoleDomain(IRoleRepository repository) : base(repository) { }
        public List<Role> Get(RoleQueryDto queryDto)
        {
            IQueryable<Role> query = _repository.Query();
            if (queryDto.RoleName != null && queryDto.RoleName != "")
            {
                query = query.Where(Role => Role.RoleName.Contains(queryDto.RoleName));
            }
     
            return query.ToList();
        }


    }
}
