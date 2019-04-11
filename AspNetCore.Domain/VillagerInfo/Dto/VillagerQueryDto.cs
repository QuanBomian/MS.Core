using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.VillagerInfo.Dto
{
    public class VillagerQueryDto
    {
        public string Name { get; set; }

        public string HomeAddress { get; set; }
        public DateTime? BirthdayFrom { get; set; }
        public DateTime? BirthdayTo { get; set; }

        public string Gender { get; set; }

        public string Education { get; set; }

        public int? AnnualIncomeFrom { get; set; }
        public int? AnnualIncomeTo { get; set; }

        public string MaritalStatus { get; set; }

        public bool? HavingIllegalRecord { get; set; }

        public bool? HavingCriminalRecord { get; set; }
    }
}
