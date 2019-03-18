using AspNetCore.Entity.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCore.Application.VillagerInformation
{
    public interface IVillagerAppService
    {
        Task<List<Villager>> GetAll();
        Villager Update(Villager villager);
        void Delete(int id);
        Villager Add(Villager villager);
        Villager Get(int id);

    }
}
