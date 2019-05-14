using AspNetCore.Domain.PartyMemberInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.PartyMemberInfo
{
    public interface IPartyMemberAppService
    {
        Task<List<PartyMember>> GetAll();
        void Update(PartyMember PartyMember);
        void Delete(Guid id);
        void Add(PartyMember PartyMember);
        PartyMember Get(Guid id);
        List<PartyMember> Search(PartyMemberQueryDto condition);
        Task<Infrastructure.Pagination.PaginatedList<PartyMember>> GetPaginationAsync(int pageIndex, int pageSize);
    }
}
