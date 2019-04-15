using AspNetCore.Entity;
using AspNetCore.Entity.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.Repository
{
    public class DepartmentRepository : Repository<Department, Guid>, IDepartmentRepository
    {
        public DepartmentRepository(MsContext context) : base(context) { }
    }
}
