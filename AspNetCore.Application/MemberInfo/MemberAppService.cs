using AspNetCore.Application.MemberInfo;
using AspNetCore.Domain.MemberInfo;
using AspNetCore.Domain.MemberInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Infrastructure.Pagination;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.MemberInfo
{
    public class MemberAppService : IMemberAppService
    {
        private readonly IMemberDomain _domain;
        public MemberAppService(IMemberDomain domain)
        {
            _domain = domain;
        }
        public void Add(Member Member)
        {
            Member.Id = Guid.NewGuid();
            _domain.Add(Member);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<Member>> GetAll()
        {
            return _domain.Get();
        }

        public Member Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(Member Member)
        {
            _domain.Update(Member);
        }

        public List<Member> Search(MemberQueryDto condition)
        {
            return _domain.Get(condition);
        }
        public async Task<PaginatedList<Member>> GetPaginationAsync(int pageIndex, int pageSize)
        {
            var query = _domain.Query();
            return await PaginatedList<Member>.CreateAsync(query, pageIndex, pageSize);
        }
    }
}
