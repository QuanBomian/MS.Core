using AspNetCore.Domain.FamilyInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.FamilyInfo
{
    public interface IFamilyDomain : IDomain<Family, Guid>
    {
        List<Family> Get(FamilyQueryDto queryDto);
    }
}
