using AspNetCore.Domain.Repository;
using AspNetCore.Domain.FamilyInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore.Domain.FamilyInfo
{
    public class FamilyDomain : Domain<Family, Guid>, IFamilyDomain
    {

        public FamilyDomain(IFamilyRepository repository) : base(repository) { }

        public List<Family> Get(FamilyQueryDto condition)
        {
            IQueryable<Family> query = _repository.Query();
            if (condition.FamilyCode != null && condition.FamilyCode.Trim() != "")
            {
                query = query.Where(Family => Family.FamilyCode.Contains(condition.FamilyCode));
            }
            if (condition.HousingArea != null)
            {
                query = query.Where(Family => Family.HousingArea == condition.HousingArea);
            }
            if (condition.Householder != null && condition.Householder.Trim() != "")
            {
                query = query.Where(Family => Family.Householder.Contains(condition.Householder));
            }
            if (condition.VillageName != null && condition.VillageName.Trim() != "")
            {
                query = query.Where(Family => Family.VillageName.Contains(condition.VillageName));
            }
            if (condition.VillageGroupCode != null && condition.VillageGroupCode.Trim() != "")
            {
                query = query.Where(Family => Family.VillageGroupCode.Contains(condition.VillageGroupCode));
            }
            if (condition.AccountCharacter != null && condition.AccountCharacter.Trim() != "")
            {
                query = query.Where(Family => Family.AccountCharacter.Contains(condition.AccountCharacter));
            }


            if (condition.PeopleNumber != null)
            {
                query = query.Where(Family => Family.PeopleNumber == condition.PeopleNumber);
            }
            if (condition.IsLowIncome != null)
            {
                query = query.Where(Family => Family.IsLowIncome == condition.IsLowIncome);
            }
            if (condition.IsPoor != null)
            {
                query = query.Where(Family => Family.IsPoor == condition.IsPoor);
            }
            if (condition.AverageHousingArea != null)
            {
                query = query.Where(Family => Family.AverageHousingArea == condition.AverageHousingArea);
            }
            if (condition.AverageAnnualIncome != null)
            {
                query = query.Where(Family => Family.AverageAnnualIncome == condition.AverageAnnualIncome);
            }



            return query.ToList();
        }
    }
}
