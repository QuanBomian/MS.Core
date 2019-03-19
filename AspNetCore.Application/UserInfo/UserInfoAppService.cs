using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Domain.UserInfo;
using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;

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
            return _domain.GetUserInfo(username, password);
        }
    }
}
