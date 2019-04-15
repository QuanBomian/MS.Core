using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.Repository
{
    public interface IPartyMemberRepository : IRepository<PartyMember, Guid>
    {
    }
}
