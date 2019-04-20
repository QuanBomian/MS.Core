using AspNetCore.Application.UserInfo;
using AspNetCore.Domain.UserInfo;
using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Infrastructure.Secret;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.UserInfo
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserDomain _domain;
        public UserAppService(IUserDomain domain)
        {
            _domain = domain;
        }
        public void Add(User User)
        {
            User.Id = Guid.NewGuid();
            User.Password = SecretHelper.GenerateHashSecret(User.Password);
            _domain.Add(User);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<User>> GetAll()
        {
            return _domain.Get();
        }

        public User Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(User User)
        {
            _domain.Update(User);
        }

        public List<User> Search(UserQueryDto condition)
        {
            return _domain.Get(condition);
        }

   
    }
}
