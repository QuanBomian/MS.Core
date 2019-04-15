using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.MemberInfo.Dto
{
    public class MemberQueryDto
    {
        public string MemberCode { get; set; }

        public string MemberName { get; set; }


        public string DepartmentCode { get; set; }

        public string HomeAddress { get; set; }
        public string Gender { get; set; }

        public string Nationality { get; set; }

        public string IdCardNumber { get; set; }

        public string Position { get; set; }

        public DateTime Birthday { get; set; }

        public string Education { get; set; }

        public string MaritalStatus { get; set; }

        public string PoliticalStatus { get; set; }

        public string PersonnelNature { get; set; }

        public string Status { get; set; }

        public DateTime EntryTime { get; set; }

        public DateTime LeaveTime { get; set; }


        public string LengthOfService { get; set; }
    
}
}
