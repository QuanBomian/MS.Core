using AspNetCore.Domain.RoleInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.RoleInfo
{
    public interface IRoleAppService
    {
        Task<List<Role>> GetAll();
        void Update(Role Role);
        void Delete(Guid id);
        void Add(Role Role);
        Role Get(Guid id);
     
    }
}
