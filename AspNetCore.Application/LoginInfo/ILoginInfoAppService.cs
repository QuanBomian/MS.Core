using AspNetCore.Application.Authorization.Dto;
using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;

namespace AspNetCore.Application.LoginInfo
{
    public interface ILoginInfoAppService
    {
        UserDto GetUserInfo(string username, string password);
        User ValidatePassword(string username, string password);
    }
}