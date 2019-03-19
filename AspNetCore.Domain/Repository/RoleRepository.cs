using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Entity;
using AspNetCore.Entity.Context;

namespace AspNetCore.Domain.Repository
{
    public class RoleRepository:Repository<Role,Guid>,IRoleRepository
    {
        public RoleRepository(MsContext context) : base(context)
        {
        }
    }
}
