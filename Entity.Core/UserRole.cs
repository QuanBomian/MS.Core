using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AspNetCore.Entity
{
    public class UserRole:EntityBase
    {
     
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid RoleId { get; set; }
        [ForeignKey("UserId")]
        
        public User User { get; set; }
        [ForeignKey("RoleId")]
        
        public Role Role { get; set; }
    }
}
