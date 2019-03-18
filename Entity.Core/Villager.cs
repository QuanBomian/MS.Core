using System;

namespace AspNetCore.Entity.Core
{
    public class Villager
    {
        /// <summary>
        /// ID自动生成
        /// </summary>
        public int VillagerID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string HomeAddress { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public string Education { get; set; }
        /// <summary>
        /// 年收入
        /// </summary>
        public int AnnualIncome { get; set; }
        /// <summary>
        /// 婚姻状况
        /// </summary>
        public string MaritalStatus { get; set; }
        /// <summary>
        /// 有无违法记录
        /// </summary>
        public bool HavingIllegalRecord { get; set; }
        /// <summary>
        /// 有无犯罪记录
        /// </summary>
        public bool HavingCriminalRecord { get; set; }
    }
}
