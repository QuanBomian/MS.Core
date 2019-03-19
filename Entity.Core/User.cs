using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AspNetCore.Entity
{
    public class User:EntityBase
    {
       
        [Required]
        [MinLength(6)]
        [MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(40)]
        public string Password { get; set; }
    }
}
