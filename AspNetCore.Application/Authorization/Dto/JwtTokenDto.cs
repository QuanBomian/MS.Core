using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Application.Authorization.Dto
{
    public class JwtTokenDto
    {
        public int UserId { get; set; }
        public String Role { get; set; }
    }
}
