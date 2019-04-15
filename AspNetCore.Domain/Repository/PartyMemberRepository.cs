using AspNetCore.Entity;
using AspNetCore.Entity.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.Repository
{
    public class PartyMemberRepository : Repository<PartyMember, Guid>, IPartyMemberRepository
    {

        public PartyMemberRepository(MsContext db) : base(db)
        {
        }


    }
}
