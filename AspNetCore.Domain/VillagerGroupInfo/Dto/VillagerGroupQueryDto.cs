﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.VillagerGroupInfo.Dto
{
    public class VillagerGroupQueryDto
    {
        public string VillageGroupCode { get; set; }
        public string PrincipalName { get; set; }

        public string PrincipalAddress { get; set; }

        public string PrincipalEmail { get; set; }

        public string PrincipalPhone { get; set; }

        public string VillageName { get; set; }

        public int? MemberNumber { get; set; }
    }
}
