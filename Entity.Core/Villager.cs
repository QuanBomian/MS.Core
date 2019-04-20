using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Entity.Core
{
    public class Villager:EntityBase
    {
    
      
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        [Required]
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Required]
        [MaxLength(3)]
        public string Gender { get; set; }
        /// <summary>
        /// 家庭住址
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string HomeAddress { get; set; }
        /// <summary>
        /// 文化水平
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string Education { get; set; }
        /// <summary>
        /// 年收入
        /// </summary>
        [Required]
        public int AnnualIncome { get; set; }
        /// <summary>
        /// 婚姻状况
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string MaritalStatus { get; set; }
        /// <summary>
        /// 有无违法记录
        /// </summary>
        [Required]
        public bool HavingIllegalRecord { get; set; }
        /// <summary>
        /// 有无犯罪记录
        /// </summary>
        [Required]
        public bool HavingCriminalRecord { get; set; }
    }
}
