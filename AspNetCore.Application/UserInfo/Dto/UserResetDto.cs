using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Application.UserInfo.Dto
{
    public class UserResetDto
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string RawPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
