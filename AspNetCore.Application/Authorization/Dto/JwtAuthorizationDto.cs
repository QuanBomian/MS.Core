using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Application.Authorization.Dto
{
    public class JwtAuthorizationDto
    {
        /// <summary>
        /// 授权时间
        /// </summary>
        public long AuthTime { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public long ExpTime { get; set; }

        /// <summary>
        /// 是否授权成功
        /// </summary>
        public bool Success { get; set; } = true;
        /// <summary>
        /// Jwt Token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 授权用户Id
        /// </summary>
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public List<string> RoleNames { get; set; }
    }
}
