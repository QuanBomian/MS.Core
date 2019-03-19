﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Domain.VillagerInfo;
using AspNetCore.Entity.Core;

namespace AspNetCore.Application.VillagerInfo
{
    public class VillagerAppService : IVillagerAppService
    {
        private readonly IVillagerDomain _domain;
        public VillagerAppService(IVillagerDomain domain)
        {
            _domain = domain;
        }
        public void Add(Villager villager)
        {
            _domain.Add(villager);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<Villager>> GetAll()
        {
            return _domain.Get();
        }

        public Villager Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(Villager villager)
        {
            _domain.Update(villager);
        }
    }
}