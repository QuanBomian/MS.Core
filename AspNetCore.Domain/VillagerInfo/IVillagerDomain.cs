using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.VillagerInfo
{
    public interface IVillagerDomain
    {
        Task<List<Villager>> Get();
        Villager GetById(Guid id);
        void Update(Villager villager);
        void  Delete(Guid id);
        void Add(Villager villager);
    }
}