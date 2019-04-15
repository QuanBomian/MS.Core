using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Application.AdminDivisionInfo
{
    public interface IAdminDivisionAppService
    {
        List<AdminDivisionDto> GetAdminDivisions();
        void Update(AdminDivision AdminDivision);
        void Delete(Guid id);
        void Add(AdminDivision AdminDivision);
        AdminDivision Get(Guid id);
        AdminDivision GetByAreaNumber(string areaNumber); 
    }
}
