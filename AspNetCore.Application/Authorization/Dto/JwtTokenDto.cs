using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Application.Authorization.Dto
{
    public class JwtTokenDto
    {
        public Guid UserId { get; set; }
        public List<String> Role { get; set; }
    }
}
