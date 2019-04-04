using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AspNetCore.Application.Authorization.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace AspNetCore.Application.Authorization
{
    public class JwtAppService : IJwtAppService
    {
        private readonly IConfiguration _configuration;

        public JwtAppService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public  string IssueJwtToken(JwtTokenDto token)
        {
            var audienceConfig = _configuration.GetSection("JwtConfig");

            DateTime datetime = DateTime.UtcNow;
            List<Claim> claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, $"{new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()}"),
                new Claim(JwtRegisteredClaimNames.Nbf, $"{new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()}"),
                new Claim(JwtRegisteredClaimNames.Exp, $"{new DateTimeOffset(DateTime.Now.AddMinutes(20)).ToUnixTimeSeconds()}"),
                new Claim(JwtRegisteredClaimNames.Iss, audienceConfig["Issuer"]),
                new Claim(JwtRegisteredClaimNames.Aud, audienceConfig["Audience"]),
                //new Claim(ClaimTypes.Role, token.Role),
            };
            foreach (var role in token.Role)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(audienceConfig["Secret"]));
            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken jwtToken = new JwtSecurityToken(
               // issuer: audienceConfig["Issuer"],
                claims: claims,
                signingCredentials: creds);
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();
            string encodedJwt = jwtHandler.WriteToken(jwtToken);
            return encodedJwt;
        }
    }
}
