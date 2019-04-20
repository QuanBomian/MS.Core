using AspNetCore.Application.UserRoleInfo;
using AspNetCore.Domain.UserRoleInfo;
using AspNetCore.Domain.UserRoleInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.UserRoleInfo
{
    public class UserRoleAppService : IUserRoleAppService
    {
        private readonly IUserRoleDomain _domain;
        public UserRoleAppService(IUserRoleDomain domain)
        {
            _domain = domain;
        }
        public void Add(UserRole UserRole)
        {
            UserRole.Id = Guid.NewGuid();
            _domain.Add(UserRole);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<UserRole>> GetAll()
        {
            return _domain.Get();
        }

        public UserRole Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(UserRole UserRole)
        {
            _domain.Update(UserRole);
        }

    
    }
}
