using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class VillagerGroup:EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string VillageGroupCode { get; set; }
        [Required]
        [MinLength(2)]
        public string PrincipalName { get; set; }
        [Required]
        [MaxLength(100)]
        public string PrincipalAddress { get; set; }
        [Required]
        public string PrincipalEmail { get; set; }
        [Required]
        [MaxLength(50)]
        public string PrincipalPhone { get; set; }
        [Required]
        public string VillageName { get; set; }
        [Required]
        public int MemberNumber { get; set; }
    }
}
