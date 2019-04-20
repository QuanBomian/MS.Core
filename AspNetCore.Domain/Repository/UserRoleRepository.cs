using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return _set.Include(r => r.Role).Include(r=>r.User).Where(r => r.UserId == userId).ToList();
        }
        public new List<UserRole> GetAll()
        {
            return _set.Include(r => r.Role).Include(r => r.User).ToList();
        }
        public new Task<List<UserRole>> GetAllAsync()
        {
            return _set.Include(r => r.Role).Include(r => r.User).ToListAsync();
        }
    }
}
