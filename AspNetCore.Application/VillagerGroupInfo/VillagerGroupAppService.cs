using AspNetCore.Application.VillagerGroupInfo;
using AspNetCore.Domain.VillagerGroupInfo;
using AspNetCore.Domain.VillagerGroupInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.VillagerGroupInfo
{
    public class VillagerGroupAppService : IVillagerGroupAppService
    {
        private readonly IVillagerGroupDomain _domain;
        public VillagerGroupAppService(IVillagerGroupDomain domain)
        {
            _domain = domain;
        }
        public void Add(VillagerGroup VillagerGroup)
        {
            VillagerGroup.Id = Guid.NewGuid();
            _domain.Add(VillagerGroup);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<VillagerGroup>> GetAll()
        {
            return _domain.Get();
        }

        public VillagerGroup Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(VillagerGroup VillagerGroup)
        {
            _domain.Update(VillagerGroup);
        }

        public List<VillagerGroup> Search(VillagerGroupQueryDto condition)
        {
            return _domain.Get(condition);
        }
    }
}
