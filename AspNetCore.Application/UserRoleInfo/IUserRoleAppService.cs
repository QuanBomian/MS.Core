using AspNetCore.Domain.UserRoleInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.UserRoleInfo
{
    public interface IUserRoleAppService
    {
        Task<List<UserRole>> GetAll();
        void Update(UserRole UserRole);
        void Delete(Guid id);
        void Add(UserRole UserRole);
        UserRole Get(Guid id);
    }
}
