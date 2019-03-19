using AspNetCore.Domain.UserInfo.Dto;

namespace AspNetCore.Application.UserInfo
{
    public interface IUserInfoAppService
    {
        UserInfoDto GetUserInfo(string username, string password);
    }
}