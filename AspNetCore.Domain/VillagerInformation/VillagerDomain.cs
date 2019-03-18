using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Domain.Respository;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.VillagerInformation
{
    public class VillagerDomain : IVillagerDomain
    {
        private readonly IVillagerRespository _respository;
        public VillagerDomain(IVillagerRespository respository)
        {
            _respository = respository;
        }

        public Task<List<Villager>> Get()
        {
            return _respository.Get();
        }

        public Villager GetById(int id)
        {
            return _respository.GetVillagerById(id);
        }

        public Villager Update(Villager villager)
        {
            return _respository.UpdateVillager(villager);
        }

        public void  Delete(int id)
        {
              _respository.DeleteVillageById(id);
        }

        public Villager Add(Villager villager)
        {
            return _respository.AddVillager(villager);
        }
    }
}
