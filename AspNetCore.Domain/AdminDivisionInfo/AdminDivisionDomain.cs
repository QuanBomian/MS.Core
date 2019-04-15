using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Domain.Repository;
using AspNetCore.Entity.Core;
using AspNetCore.Entity;

namespace AspNetCore.Domain.AdminDivisionInfo
{
    public class AdminDivisionDomain : Domain<AdminDivision, Guid>, IAdminDivisionDomain
    {

        public AdminDivisionDomain(IAdminDivisionRepository repository) : base(repository) { }


    }
}
