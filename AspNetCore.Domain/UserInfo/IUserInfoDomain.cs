using AspNetCore.Domain.UserInfo.Dto;

namespace AspNetCore.Domain.UserInfo
{
    public interface IUserInfoDomain
    {
        UserInfoDto GetUserInfo(string username,string password);
    }
}