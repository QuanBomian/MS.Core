using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;

namespace AspNetCore.Domain.UserInfo
{
    public interface IUserInfoDomain
    {
        List<string> GetUserInfo(Guid id);
        User GetUserByPassword(string username);
    }
}