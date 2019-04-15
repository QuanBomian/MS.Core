using AspNetCore.Domain.MemberInfo.Dto;
using AspNetCore.Domain.Repository;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore.Domain.MemberInfo
{
    public class MemberDomain : Domain<Member, Guid>, IMemberDomain
    {
        public MemberDomain(IMemberRepository repository) : base(repository) { }

        public List<Member> Get(MemberQueryDto condition)
        {
            IQueryable<Member> query = _repository.Query();
            if (condition.MemberName != null && condition.MemberName.Trim() != "")
            {
                query = query.Where(Member => Member.MemberName.Contains(condition.MemberName));
            }
            if (condition.MemberCode != null && condition.MemberCode.Trim() != "")
            {
                query = query.Where(Member => Member.MemberCode.Contains(condition.MemberCode));
            }
            if (condition.HomeAddress != null && condition.HomeAddress.Trim() != "")
            {
                query = query.Where(Member => Member.HomeAddress.Contains(condition.HomeAddress));
            }
            if (condition.IdCardNumber != null && condition.IdCardNumber.Trim() != "")
            {
                query = query.Where(Member => Member.IdCardNumber.Contains(condition.IdCardNumber));
            }
            if (condition.MaritalStatus != null && condition.MaritalStatus.Trim() != "")
            {
                query = query.Where(Member => Member.MaritalStatus.Contains(condition.MaritalStatus));
            }
            if (condition.Nationality != null && condition.Nationality.Trim() != "")
            {
                query = query.Where(Member => Member.Nationality.Contains(condition.Nationality));
            }
            if (condition.PoliticalStatus != null && condition.PoliticalStatus.Trim() != "")
            {
                query = query.Where(Member => Member.PoliticalStatus.Contains(condition.PoliticalStatus));
            }
            if (condition.Position != null && condition.Position.Trim() != "")
            {
                query = query.Where(Member => Member.Position.Contains(condition.Position));
            }
            if (condition.Status != null && condition.Status.Trim() != "")
            {
                query = query.Where(Member => Member.Status.Contains(condition.Status));

               

                
            }
            if (condition.Gender != null && condition.Gender.Trim() != "")
            {
                query = query.Where(Member => Member.Gender.Contains(condition.Gender));
            }
            if (condition.LengthOfService != null && condition.LengthOfService.Trim() != "")
            {
                query = query.Where(Member => Member.LengthOfService.Contains(condition.LengthOfService));
            }
            if (condition.Birthday != null)
            {
                query = query.Where(Member => Member.Birthday == condition.Birthday);
            }
            if (condition.EntryTime != null)
            {
                query = query.Where(Member => Member.EntryTime == condition.EntryTime);
            }
            if (condition.LeaveTime != null)
            {
                query = query.Where(Member => Member.LeaveTime == condition.LeaveTime);
            }
            return query.ToList();


        }
    }
}
