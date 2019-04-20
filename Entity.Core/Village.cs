using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AspNetCore.Entity
{
    public class Village:EntityBase
    {
        /// <summary>
        /// 村名
        /// </summary>
        [Required]
        public string VillageName { get; set; }
        /// <summary>
        /// 行政编码
        /// 国家统计局规定行政编码为12位阿拉伯数字
        /// 
        /// </summary>
        [Required]
        [MaxLength(15)]
        public string AreaNumber { get; set; }
        /// <summary>
        /// 上级行政区编码
        /// </summary>
        [Required]
        [MaxLength(15)]
        public string HighLevelAreaNumber { get; set; }
        /// <summary>
        /// 行政级别
        /// </summary>
        [Required]
        public int GovernmentLevel { get; set; }
        /// <summary>
        /// 城乡分类
        /// </summary>
        /// 
        [Required]
        public int UrbanRuralClassification { get; set; }
        /// <summary>
        /// 党支部书记姓名
        /// </summary>
        /// 
        [Required]
        public string SecretaryName { get; set; }
        /// <summary>
        /// 村长姓名
        /// </summary>
        /// 
        [Required]
        public string VillageHeadName { get; set; }
        /// <summary>
        /// 办公地址
        /// </summary>
        /// 
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        /// <summary>
        /// 办公电话
        /// </summary>
        /// 
        [Required]
        [MaxLength(50)]
        public string ContactPhone { get; set; }
        /// <summary>
        /// 村民小组数量
        /// </summary>
        public int? GroupCount { get; set; }
    }
}
