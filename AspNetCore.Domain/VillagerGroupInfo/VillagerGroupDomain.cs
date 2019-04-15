using AspNetCore.Domain.Repository;
using AspNetCore.Domain.VillagerGroupInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore.Domain.VillagerGroupInfo
{
    public class VillagerGroupDomain : Domain<VillagerGroup, Guid>, IVillagerGroupDomain
    {

        public VillagerGroupDomain(IVillagerGroupRepository repository) : base(repository) { }

        public List<VillagerGroup> Get(VillagerGroupQueryDto condition)
        {
            IQueryable<VillagerGroup> query = _repository.Query();
            if (condition.PrincipalName != null && condition.PrincipalName.Trim() != "")
            {
                query = query.Where(VillagerGroup => VillagerGroup.PrincipalName.Contains(condition.PrincipalName));
            }
            if (condition.PrincipalAddress != null)
            {
                query = query.Where(VillagerGroup => VillagerGroup.PrincipalAddress == condition.PrincipalAddress);
            }
            if (condition.PrincipalEmail != null && condition.PrincipalEmail.Trim() != "")
            {
                query = query.Where(VillagerGroup => VillagerGroup.PrincipalEmail.Contains(condition.PrincipalEmail));
            }
            if (condition.PrincipalPhone != null && condition.PrincipalPhone.Trim() != "")
            {
                query = query.Where(VillagerGroup => VillagerGroup.PrincipalPhone.Contains(condition.PrincipalPhone));
            }

            if (condition.VillageGroupCode != null && condition.VillageGroupCode.Trim() != "")
            {
                query = query.Where(VillagerGroup => VillagerGroup.VillageGroupCode.Contains(condition.VillageGroupCode));
            }
            if (condition.VillageName != null && condition.VillageName.Trim() != "")
            {
                query = query.Where(VillagerGroup => VillagerGroup.VillageName.Contains(condition.VillageName));
            }

            return query.ToList();
        }
    }
}
