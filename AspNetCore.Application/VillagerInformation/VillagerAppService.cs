using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Domain.VillagerInformation;
using AspNetCore.Entity.Core;

namespace AspNetCore.Application.VillagerInformation
{
    public class VillagerAppService : IVillagerAppService
    {
        private readonly IVillagerDomain _domain;
        public VillagerAppService(IVillagerDomain domain)
        {
            _domain = domain;
        }
        public Villager Add(Villager villager)
        {
           return  _domain.Add(villager);
        }

        public void Delete(int id)
        {
            _domain.Delete(id);
        }

        public Task<List<Villager>> GetAll()
        {
            return _domain.Get();
        }

        public Villager Get(int id)
        {
            return _domain.GetById(id);
        }

        public Villager Update(Villager villager)
        {
            return _domain.Update(villager);
        }
    }
}
