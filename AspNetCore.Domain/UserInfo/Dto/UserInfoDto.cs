using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Entity;

namespace AspNetCore.Domain.UserInfo.Dto
{
    public class UserInfoDto
    {
        public bool Success { get; set; }
        public Guid UserId { get; set; }
        public List<string> RoleNames { get; set;}

    }
}
