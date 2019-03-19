using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AspNetCore.Entity;
using AspNetCore.Entity.Context;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Domain.Repository
{
    public class UserRoleRepository:Repository<UserRole,Guid>,IUserRoleRepository
    {
        public UserRoleRepository(MsContext context) : base(context)
        {
        }

        public List<UserRole> GetRolesByUserId(Guid userId)
        {
            return _set.Include(r => r.Role).Where(r => r.UserId == userId).ToList();
        }
    }
}
