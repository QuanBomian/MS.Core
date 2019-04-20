using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.UserInfo
{
    public interface IUserAppService
    {
        Task<List<User>> GetAll();
        void Update(User User);
        void Delete(Guid id);
        void Add(User User);
        User Get(Guid id);
        List<User> Search(UserQueryDto condition);
       
    }
}
