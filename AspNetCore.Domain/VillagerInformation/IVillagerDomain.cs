using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.VillagerInformation
{
    public interface IVillagerDomain
    {
        Task<List<Villager>> Get();
        Villager GetById(int id);
        Villager Update(Villager villager);
        void  Delete(int id);
        Villager Add(Villager villager);
    }
}