using AspNetCore.Entity;
using AspNetCore.Entity.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.Repository
{
    public class MemberRepository : Repository<Member, Guid>, IMemberRepository
    {
        public MemberRepository(MsContext context) : base(context) { }
    }
}
