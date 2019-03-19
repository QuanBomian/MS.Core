using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspNetCore.Entity
{
    public class Role:EntityBase
    {
      
        [Required]
        public string RoleName { get; set; }
    }
}
