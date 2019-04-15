using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Entity
{
    public class Town : EntityBase
    {
        /// <summary>
        /// 乡镇名
        /// </summary>
        public string TownName { get; set; }

        public string AreaNumber { get; set; }
        public int GovernmentLevel { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 镇长姓名
        /// </summary>
        public string MayorName { get; set; }
        /// <summary>
        /// 党委书记姓名
        /// </summary>
        public string SecretaryName {get;set;}

        /// <summary>
        /// 人大委员长姓名
        /// </summary>
        public string ChairmanName { get; set; }
        /// <summary>
        /// 办公室联系电话
        /// </summary>
        public string ContactPhone { get; set; }
    }
}
