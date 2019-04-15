using AspNetCore.Domain.VillagerGroupInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.VillagerGroupInfo
{
    public interface IVillagerGroupDomain : IDomain<VillagerGroup, Guid>
    {
        List<VillagerGroup> Get(VillagerGroupQueryDto queryDto);
    }
}
