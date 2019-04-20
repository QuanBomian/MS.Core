using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class DataItem:EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string ItemCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string CategroyCode { get; set; }
        [Required]
        public string Content { get; set; }

    }
}
