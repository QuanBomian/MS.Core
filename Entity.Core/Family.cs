using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class Family:EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string FamilyCode { get; set; }
        [Required]
        [MinLength(2)]
        public string Householder { get; set; }
        [Required]

        public int PeopleNumber { get; set; }
        [Required]
        [MaxLength(3)]
        public string AccountCharacter { get; set; }
        [Required]
        public string VillageName { get; set; }
        [Required]
        [MaxLength(50)]
        public string VillageGroupCode { get; set; }
        [Required]
        public int AverageAnnualIncome { get; set; }
        [Required]
        public float HousingArea { get; set; }
        [Required]
        public float AverageHousingArea { get; set; }
        [Required]
        public bool IsLowIncome { get; set; }
        [Required]
        public bool IsPoor { get; set; }
    }
}
