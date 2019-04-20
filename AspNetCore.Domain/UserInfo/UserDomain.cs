using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Domain.Repository;
using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.UserInfo
{
    public class UserDomain : Domain<User, Guid>, IUserDomain
    {

        public UserDomain(IUserRepository repository) : base(repository) { }
        public List<User> Get(UserQueryDto queryDto)
        {
            IQueryable<User> query = _repository.Query();
            if (queryDto.UserName != null && queryDto.UserName != "")
            {
                query = query.Where(User => User.UserName.Contains(queryDto.UserName));
            }
           

            return query.ToList();
        }

        public  User GetUserForLoginAsync(string account)
        {
            return   _repository.Query(a => a.UserName == account).FirstOrDefault();
            
        }

        public Task<User> GetUserForLoginAsync(string account, string password)
        {
            throw new NotImplementedException();
        }
    }
}
