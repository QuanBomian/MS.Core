using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class PartyMember:EntityBase
    {
        [Required]
        [MaxLength(100)]
        public string PartyMemberCode { get; set; }
        [Required]
        [MinLength(2)]
        public string PartyMemberName { get; set; }
        [Required]
        [MaxLength(3)]
        public string Gender { get; set; }
        [Required]
        [MaxLength(10)]
        public string Nationality { get; set; }
        [Required]
        [MaxLength(10)]
        public string Education { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public string VillageName { get; set; }
        [Required]
        [MaxLength(50)]
        public string DepartmentCode { get; set; }
        [Required]
        public string PartyOrganizationName { get; set; }
        [Required]
        [MaxLength(10)]
        public string PartyPosition { get; set; }
        [Required]
        [MaxLength(50)]
        public string ContactPhone { get; set; }
        [Required]
        public bool IsFullMember { get; set; }


    }
}
