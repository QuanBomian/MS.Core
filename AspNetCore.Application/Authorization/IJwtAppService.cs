using AspNetCore.Application.Authorization.Dto;

namespace AspNetCore.Application.Authorization
{
    public interface IJwtAppService
    {
        string IssueJwtToken(JwtTokenDto token);
    }
}