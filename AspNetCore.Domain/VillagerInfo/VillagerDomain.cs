using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Domain.Repository;
using AspNetCore.Domain.VillagerInfo.Dto;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.VillagerInfo
{
    public class VillagerDomain : Domain<Villager, Guid>,IVillagerDomain
    {

        public VillagerDomain(IVillagerRepository repository) : base(repository) { }
        public List<Villager> Get(VillagerQueryDto queryDto)
        {
            IQueryable<Villager> query = _repository.Query();
            if (queryDto.Name != null && queryDto.Name !="") {
                query = query.Where(villager => villager.Name.Contains(queryDto.Name));
            }
            if (queryDto.HomeAddress != null && queryDto.HomeAddress !="")
            {
                query = query.Where(villager => villager.HomeAddress.Contains(queryDto.HomeAddress));
            }
            if(queryDto.AnnualIncomeFrom != null)
            {
                query = query.Where(villager => villager.AnnualIncome >= queryDto.AnnualIncomeFrom);
            }
            if(queryDto.AnnualIncomeTo != null)
            {
                query = query.Where(villager => villager.AnnualIncome <= queryDto.AnnualIncomeTo);
            }
            if (queryDto.Education != null && queryDto.Education !="")
            {
                query = query.Where(villager => villager.Education == queryDto.Education);
            }
            if(queryDto.Gender != null && queryDto.Gender !="")
            {
                query = query.Where(villager => villager.Gender == queryDto.Gender);
            }
            if(queryDto.HavingCriminalRecord != null)
            {
                query = query.Where(villager => villager.HavingCriminalRecord == queryDto.HavingCriminalRecord);
            }

            if(queryDto.HavingIllegalRecord != null)
            {
                query = query.Where(villager => villager.HavingIllegalRecord
               == queryDto.HavingIllegalRecord);
            }
                   
            if(queryDto.MaritalStatus != null && queryDto.MaritalStatus !="")
            {
                query = query.Where(villager => villager.MaritalStatus == queryDto.MaritalStatus);
            }
             if(queryDto.BirthdayFrom != null)
            {
                query = query.Where(villager => villager.Birthday >= queryDto.BirthdayFrom);
            }
             if(queryDto.BirthdayTo != null)
            {
                query = query.Where(villager => villager.Birthday <= queryDto.BirthdayTo);
            }
         
            return query.ToList();
        }

       
    }
}
