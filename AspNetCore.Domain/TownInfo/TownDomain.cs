using AspNetCore.Domain.Repository;
using AspNetCore.Domain.TownInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore.Domain.TownInfo
{
    public class TownDomain: Domain<Town, Guid>,ITownDomain
    {
        public TownDomain(ITownRepository repository) : base(repository) {  }

        public List<Town> Get(TownQueryDto condition)
        {
            IQueryable<Town> query = _repository.Query();
            if (condition.TownName != null && condition.TownName.Trim() != "")
            {
                query = query.Where(town => town.TownName.Contains(condition.TownName));
            }
            if (condition.Address != null && condition.Address.Trim() != "")
            {
                query = query.Where(town => town.Address.Contains(condition.Address));
            }
            if (condition.MayorName != null &&condition.MayorName.Trim()!="")
            {
                query = query.Where(town => town.MayorName.Contains(condition.MayorName));
            }
            if (condition.SecretaryName != null && condition.SecretaryName.Trim() != "")
            {
                query = query.Where(town => town.Address.Contains(condition.SecretaryName));
            }
            if (condition.ChairmanName != null && condition.ChairmanName.Trim() != "")
            {
                query = query.Where(town => town.ChairmanName.Contains(condition.ChairmanName));
            }
            if (condition.ContactPhone != null && condition.ContactPhone.Trim() != "")
            {
                query = query.Where(town => town.ContactPhone.Contains(condition.ContactPhone));
            }
            if (condition.AreaNumber != null && condition.AreaNumber.Trim() != "")
            {
                query = query.Where(town => town.AreaNumber.Contains(condition.AreaNumber));
            }
            if (condition.GovernmentLevel != null)
            {
                query = query.Where(town => town.GovernmentLevel == condition.GovernmentLevel);
            }

            return query.ToList();
        }
    }
}
