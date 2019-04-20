using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.PartyMemberInfo.Dto
{
    public class PartyMemberQueryDto
    {

        public string MemberCode { get; set; }

        public string PartyMemberName { get; set; }

        public string Gender { get; set; }

        public string Nationality { get; set; }

        public string Education { get; set; }

        public DateTime? BirthdayFrom { get; set; }

        public DateTime? BirthdayTo { get; set; }

        public string VillageName { get; set; }

        public string DepartmentCode { get; set; }
        public string PartyOrganizationName { get; set; }

        public string PartyPosition { get; set; }

        public string ContactPhone { get; set; }

        public bool? IsFullMember { get; set; }

    }
}
