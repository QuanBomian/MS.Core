using AspNetCore.Application.PartyMemberInfo;
using AspNetCore.Domain.PartyMemberInfo;
using AspNetCore.Domain.PartyMemberInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.PartyMemberInfo
{
    public class PartyMemberAppService : IPartyMemberAppService
    {
        private readonly IPartyMemberDomain _domain;
        public PartyMemberAppService(IPartyMemberDomain domain)
        {
            _domain = domain;
        }
        public void Add(PartyMember PartyMember)
        {
            PartyMember.Id = Guid.NewGuid();
            _domain.Add(PartyMember);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<PartyMember>> GetAll()
        {
            return _domain.Get();
        }

        public PartyMember Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(PartyMember PartyMember)
        {
            _domain.Update(PartyMember);
        }

        public List<PartyMember> Search(PartyMemberQueryDto condition)
        {
            return _domain.Get(condition);
        }
    }
}
