using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.Respository
{
    public interface IVillagerRespository
    {
        Task<List<Villager>> Get();
        Villager GetVillagerById(int id);
        Villager AddVillager(Villager villager);
        Villager UpdateVillager(Villager villager);
        void DeleteVillageById(int id);
    }
}