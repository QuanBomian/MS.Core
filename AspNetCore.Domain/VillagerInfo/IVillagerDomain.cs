using System;
using System.Collections.Generic;
using AspNetCore.Domain.VillagerInfo.Dto;
using AspNetCore.Entity.Core;
namespace AspNetCore.Domain.VillagerInfo
{
    public interface IVillagerDomain:IDomain<Villager,Guid>
    {
        List<Villager> Get(VillagerQueryDto queryDto);
    }
}