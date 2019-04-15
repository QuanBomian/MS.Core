using AspNetCore.Domain.DepartmentInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.DepartmentInfo
{
    public interface IDepartmentDomain : IDomain<Department, Guid>
    {
        List<Department> Get(DepartmentQueryDto condition);
    }
}
