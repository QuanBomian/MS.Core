using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Entity
{
    public class AdminDivision : EntityBase { 

        public string HighLevelAreaNumber { get; set; }
        public string AreaNumber { get; set; }

        public int GovernmentLevel { get; set; }

        public string GovernmentName { get; set; }
        /// <summary>
        /// 下属县数量
        /// </summary>
        public int CountyNumber { get; set; }

        public int TownNumber { get; set; }

        public int VillageNumber { get; set; }

        public int VillageGroupNumber { get; set; }

    }
}
