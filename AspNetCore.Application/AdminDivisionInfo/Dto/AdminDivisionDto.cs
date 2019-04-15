using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Application.AdminDivisionInfo
{
    public class AdminDivisionDto
    {
        public Guid Id { get; set; }
        public string AreaNumber { get; set; }

        public string GovernmentName { get; set; }

        public List<AdminDivisionDto> Children { get; set; }
    }
}
