using AspNetCore.Domain.MemberInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.MemberInfo
{
    public interface IMemberDomain : IDomain<Member, Guid>
    {
        List<Member> Get(MemberQueryDto condition);
    }
}
