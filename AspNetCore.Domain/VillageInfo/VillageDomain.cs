using AspNetCore.Domain.Repository;
using AspNetCore.Domain.VillageInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore.Domain.VillageInfo
{
    public class VillageDomain: Domain<Village, Guid>, IVillageDomain
    {

        public VillageDomain(IVillageRepository repository) : base(repository) { }

        public List<Village> Get(VillageQueryDto condition)
        {
            IQueryable<Village> query = _repository.Query();
            if (condition.VillageName != null && condition.VillageName.Trim() != "")
            {
                query = query.Where(village => village.VillageName.Contains(condition.VillageName));
            }
            if (condition.UrbanRuralClassification != null)
            {
                query = query.Where(village => village.UrbanRuralClassification==condition.UrbanRuralClassification);
            }
            if (condition.Address != null && condition.Address.Trim() != "")
            {
                query = query.Where(village => village.Address.Contains(condition.Address));
            }
            if (condition.SecretaryName != null && condition.SecretaryName.Trim() != "")
            {
                query = query.Where(village => village.Address.Contains(condition.SecretaryName));
            }
    
            if (condition.ContactPhone != null && condition.ContactPhone.Trim() != "")
            {
                query = query.Where(village => village.ContactPhone.Contains(condition.ContactPhone));
            }
            if (condition.AreaNumber != null && condition.AreaNumber.Trim() != "")
            {
                query = query.Where(village => village.ContactPhone.Contains(condition.ContactPhone));
            }
            if (condition.GroupCount != null )
            {
                query = query.Where(village => village.GroupCount==condition.GroupCount);
            }
            if (condition.GovernmentLevel != null)
            {
                query = query.Where(village => village.GovernmentLevel == condition.GovernmentLevel);
            }

            return query.ToList();
        }
    }
}
