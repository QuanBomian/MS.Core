using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Application.Authorization.Dto
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }


        public List<string> RoleName { get; set; }

    }
}
