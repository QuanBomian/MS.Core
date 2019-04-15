using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;

namespace AspNetCore.Application.UserInfo
{
    public interface IUserInfoAppService
    {
        UserInfoDto GetUserInfo(string username, string password);
        User ValidatePassword(string username, string password);
    }
}