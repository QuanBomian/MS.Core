using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class Menu:EntityBase
    {
        [Required]
        public string Url { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
