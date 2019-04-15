using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Entity;
using AspNetCore.Entity.Context;

namespace AspNetCore.Domain.Repository
{
    public class AdminDivisionRepository : Repository<AdminDivision, Guid>, IAdminDivisionRepository
    {
        public AdminDivisionRepository(MsContext context) : base(context)
        {
        }
    }
}
