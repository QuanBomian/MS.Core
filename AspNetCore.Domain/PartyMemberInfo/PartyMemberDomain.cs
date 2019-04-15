using AspNetCore.Domain.Repository;
using AspNetCore.Domain.PartyMemberInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore.Domain.PartyMemberInfo
{
    public class PartyMemberDomain : Domain<PartyMember, Guid>, IPartyMemberDomain
    {

        public PartyMemberDomain(IPartyMemberRepository repository) : base(repository) { }

        public List<PartyMember> Get(PartyMemberQueryDto condition)
        {
            IQueryable<PartyMember> query = _repository.Query();
            if (condition.PartyMemberName != null && condition.PartyMemberName.Trim() != "")
            {
                query = query.Where(PartyMember => PartyMember.PartyMemberName.Contains(condition.PartyMemberName));
            }
            if (condition.IsFullMember != null)
            {
                query = query.Where(PartyMember => PartyMember.IsFullMember == condition.IsFullMember);
            }
            if (condition.MemberCode != null && condition.MemberCode.Trim() != "")
            {
                query = query.Where(PartyMember => PartyMember.MemberCode.Contains(condition.MemberCode));
            }
            if (condition.Gender != null && condition.Gender.Trim() != "")
            {
                query = query.Where(PartyMember => PartyMember.Gender.Contains(condition.Gender));
            }

            if (condition.Nationality != null && condition.Nationality.Trim() != "")
            {
                query = query.Where(PartyMember => PartyMember.Nationality.Contains(condition.Nationality));
            }
            if (condition.Education != null && condition.Education.Trim() != "")
            {
                query = query.Where(PartyMember => PartyMember.ContactPhone.Contains(condition.ContactPhone));
            }
            if (condition.VillageName != null && condition.VillageName.Trim() != "")
            {
                query = query.Where(PartyMember => PartyMember.VillageName.Contains(condition.VillageName));
            }
            if (condition.DepartmentCode != null && condition.DepartmentCode.Trim() != "")
            {
                query = query.Where(PartyMember => PartyMember.DepartmentCode.Contains(condition.DepartmentCode));
            }
            if (condition.PartyOrganizationName != null && condition.PartyOrganizationName.Trim() != "")
            {
                query = query.Where(PartyMember => PartyMember.PartyOrganizationName.Contains(condition.PartyOrganizationName));
            }
            if (condition.PartyPosition != null && condition.PartyPosition.Trim() != "")
            {
                query = query.Where(PartyMember => PartyMember.PartyPosition.Contains(condition.PartyPosition));
            }
            if (condition.ContactPhone != null && condition.ContactPhone.Trim() != "")
            {
                query = query.Where(PartyMember => PartyMember.ContactPhone.Contains(condition.ContactPhone));
            }
       
            if (condition.Birthday != null)
            {
                query = query.Where(PartyMember => PartyMember.Birthday == condition.Birthday);
            }
          

            return query.ToList();
        }
    }
}

