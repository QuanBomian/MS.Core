using AspNetCore.Domain.VillageInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.VillageInfo
{
    public interface IVillageDomain : IDomain<Village, Guid>
    {
        List<Village> Get(VillageQueryDto queryDto);
    }
}
