using AspNetCore.Domain.PartyMemberInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.PartyMemberInfo
{
    public interface IPartyMemberDomain : IDomain<PartyMember, Guid>
    {
        List<PartyMember> Get(PartyMemberQueryDto queryDto);
    }
}
