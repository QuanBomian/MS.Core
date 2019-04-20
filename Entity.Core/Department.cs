using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class Department:EntityBase
    {
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        [MaxLength(100)]
        public string DepartmentCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        [Required]
        [MinLength(2)]
        public string PrincipalName { get; set; }
        [Required]
        [MaxLength(50)]
        public string ContactPhone { get; set; }
        [Required]
        [MaxLength(50)]
        public string Fax { get; set; }
        [Required]
        public string Email { get; set; }

        public string Notes { get; set; }
    }
}
