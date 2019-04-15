using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Domain.UserInfo;
using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Infrastructure.Secret;

namespace AspNetCore.Application.UserInfo
{
    public class UserInfoAppService : IUserInfoAppService
    {
        
        private readonly IUserInfoDomain _domain;
        public UserInfoAppService(IUserInfoDomain domain)
        {
            _domain = domain;
        }

        public UserInfoDto GetUserInfo(string username, string password)
        {
            var user = ValidatePassword(username, password);
            if (user==null)
            {
                return new UserInfoDto
                {
                    Success = false
                };
            }
            else
            {
                return new UserInfoDto
                {
                    Success = true,
                    Username = username,
                    UserId = user.Id,
                    RoleNames = _domain.GetUserInfo(user.Id)
                };
            }
            } 

        public User ValidatePassword(string username, string password)
        {
            var user = _domain.GetUserByPassword(username);
            var hashed = SecretHelper.GenerateHashSecret(password);
            if (user.Password == hashed)
                return user;
            else
                return null;

        }
    }
}
