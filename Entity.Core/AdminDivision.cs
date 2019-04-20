using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class AdminDivision : EntityBase { 
        
        public string HighLevelAreaNumber { get; set; }
        [Required]
        [MaxLength(15)]
        public string AreaNumber { get; set; }
        [Required]
        public int GovernmentLevel { get; set; }
        [Required]
        public string GovernmentName { get; set; }
        /// <summary>
        /// 下属县数量
        /// </summary>
        [Required]
        public int CountyNumber { get; set; }
        [Required]
        public int TownNumber { get; set; }
        [Required]
        public int VillageNumber { get; set; }
        [Required]
        public int VillageGroupNumber { get; set; }

    }
}
