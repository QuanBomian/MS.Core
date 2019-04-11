using AspNetCore.Domain.TownInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.TownInfo
{
    public interface ITownDomain : IDomain<Town, Guid>
    {
        List<Town> Get(TownQueryDto condition);
    }
}
