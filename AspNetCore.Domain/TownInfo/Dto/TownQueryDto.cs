using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.TownInfo.Dto
{
    public class TownQueryDto
    {
        public String TownName { get; set; }

        public String Address { get; set; }

        public String MayorName { get; set; }

        public String SecretaryName { get; set; }

        public String ChairmanName { get; set; }

        public String ContactPhone { get; set; }
    }
}
