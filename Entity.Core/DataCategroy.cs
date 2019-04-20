using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class DataCategroy:EntityBase
    {
        [Required]
        [MaxLength(50)]
        public String CategroyCode { get; set; }
        [Required]
        public String CategroyName { get; set; }
    }
}
