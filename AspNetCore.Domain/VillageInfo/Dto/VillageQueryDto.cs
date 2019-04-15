using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.VillageInfo.Dto
{
    public class VillageQueryDto
    {
        /// <summary>
        /// 村名
        /// </summary>
        public string VillageName { get; set; }
        /// <summary>
        /// 行政编码
        /// </summary>
        public string AreaNumber { get; set; }
        public int? GovernmentLevel { get; set; }
        /// <summary>
        /// 城乡分类
        /// </summary>
        public int? UrbanRuralClassification { get; set; }
        /// <summary>
        /// 党支部书记姓名
        /// </summary>
        public string SecretaryName { get; set; }
        /// <summary>
        /// 村长姓名
        /// </summary>
        public string VillageHeadName { get; set; }
        /// <summary>
        /// 办公地址
        /// </summary>
        public string Address { get; set; }
        public string ContactPhone { get; set; }

        public int? GroupCount { get; set; }
    }
}
