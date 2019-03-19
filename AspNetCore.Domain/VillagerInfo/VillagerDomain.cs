using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Domain.Repository;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.VillagerInfo
{
    public class VillagerDomain : IVillagerDomain
    {
        private readonly IVillagerRepository _repository;
        public VillagerDomain(IVillagerRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Villager>> Get()
        {
            return _repository.GetAllAsync();
        }

        public Villager GetById(Guid id)
        {
            return _repository.GetByKey(id);
        }

        public void Update(Villager villager)
        {
             _repository.Update(villager);
        }

        public void  Delete(Villager villager)
        {
              _repository.Remove(villager);
        }

        public void Add(Villager villager)
        {
            _repository.Insert(villager);
        }

        public void Delete(Guid id)
        {
            _repository.Remove(id);
        }
    }
}
