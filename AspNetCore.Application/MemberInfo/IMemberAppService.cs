using AspNetCore.Domain.MemberInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.MemberInfo
{
    public interface IMemberAppService
    {
        Task<List<Member>> GetAll();
        void Update(Member Member);
        void Delete(Guid id);
        void Add(Member Member);
        Member Get(Guid id);
        List<Member> Search(MemberQueryDto condition);
    }
}
