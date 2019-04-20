using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Application.Authorization.Dto;
using AspNetCore.Domain.UserInfo;
using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Infrastructure.Secret;

namespace AspNetCore.Application.LoginInfo
{
    public class LoginInfoAppService : ILoginInfoAppService
    {
        
        private readonly IUserInfoDomain _domain;
        public LoginInfoAppService(IUserInfoDomain domain)
        {
            _domain = domain;
        }

        public UserDto GetUserInfo(string username, string password)
        {
            var user = ValidatePassword(username, password);
            if (user==null)
            {
                return null;
            }
            else
            {
                return new UserDto
                {
          
                    UserName = username,
                    Id = user.Id,
                    RoleName = _domain.GetUserInfo(user.Id)
                };
            }
            } 

        public User ValidatePassword(string username, string password)
        {
            var user = _domain.GetUserByPassword(username);
            if (user == null)
                return null;
            var hashed = SecretHelper.GenerateHashSecret(password);
            if (user.Password == hashed)
                return user;
            else
                return null;

        }
    }
}
