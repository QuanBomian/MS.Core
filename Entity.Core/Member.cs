using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class Member : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string MemberCode { get; set; }
        [Required]
        [MinLength(2)]
        public string MemberName { get; set; }
        [Required]
        [MaxLength(50)]
        public string DepartmentCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string HomeAddress { get; set; }
        [Required]
        [MaxLength(3)]
        public string Gender { get; set; }
        [Required]
        [MaxLength(10)]
        public string Nationality { get; set; }
        [Required]
        [MaxLength(18)]
        public string IdCardNumber { get; set; }
        [Required]
        [MaxLength(20)]
        public string Position { get; set; }
        [Required]

        public DateTime Birthday { get; set; }
        [Required]
        [MaxLength(10)]
        public string Education { get; set; }
        [Required]
        [MaxLength(10)]
        public string MaritalStatus { get; set; }
        [Required]
        [MaxLength(10)]
        public string PoliticalStatus { get; set; }
       
        [MaxLength(10)]
        public string PersonnelNature { get; set; }
        [Required]
        [MaxLength(10)]
        public string Status { get; set; }
        [Required]
        public DateTime EntryTime{get;set;}

        public DateTime LeaveTime { get; set; }

        [Required]
        [MaxLength(50)]
        public string LengthOfService { get; set; }
    }
}
