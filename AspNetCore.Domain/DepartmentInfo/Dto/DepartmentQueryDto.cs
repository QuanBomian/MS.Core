using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.DepartmentInfo.Dto
{
    public class DepartmentQueryDto
    {
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }

        public string Address { get; set; }

        public string PrincipalName { get; set; }

        public string ContactPhone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string Notes { get; set; }
    }
}
