using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class Town : EntityBase
    {
        /// <summary>
        /// 乡镇名
        /// </summary>
        /// 
        [Required]
        public string TownName { get; set; }
        /// <summary>
        /// 乡镇行政编码
        /// </summary>
        [Required]
        [MaxLength(15)]
        public string AreaNumber { get; set; }
        /// <summary>
        /// 行政级别
        /// </summary>
        [Required]
        public int GovernmentLevel { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        /// 
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        /// <summary>
        /// 镇长姓名
        /// </summary>
        /// 
        [Required]
        [MinLength(2)]
        public string MayorName { get; set; }
        /// <summary>
        /// 党委书记姓名
        /// </summary>
        /// 
        [Required]
        [MinLength(2)]
        public string SecretaryName {get;set;}

        /// <summary>
        /// 人大委员长姓名
        /// </summary>
        /// 
        [Required]
        [MinLength(2)]
        public string ChairmanName { get; set; }
        /// <summary>
        /// 办公室联系电话
        /// </summary>
        /// 
        [Required]
        [MaxLength(50)]
        public string ContactPhone { get; set; }
    }
}
