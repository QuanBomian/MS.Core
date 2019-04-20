using AspNetCore.Application.RoleInfo;
using AspNetCore.Domain.RoleInfo;
using AspNetCore.Domain.RoleInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.RoleInfo
{
    public class RoleAppService : IRoleAppService
    {
        private readonly IRoleDomain _domain;
        public RoleAppService(IRoleDomain domain)
        {
            _domain = domain;
        }
        public void Add(Role Role)
        {
            Role.Id = Guid.NewGuid();
            _domain.Add(Role);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<Role>> GetAll()
        {
            return _domain.Get();
        }

        public Role Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(Role Role)
        {
            _domain.Update(Role);
        }

        public List<Role> Search(RoleQueryDto condition)
        {
            return _domain.Get(condition);
        }
    }
}
