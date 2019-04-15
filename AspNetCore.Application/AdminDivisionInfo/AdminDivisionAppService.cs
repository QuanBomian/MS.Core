using AspNetCore.Application.TownInfo;
using AspNetCore.Application.VillageInfo;
using AspNetCore.Domain.AdminDivisionInfo;
using AspNetCore.Domain.TownInfo;
using AspNetCore.Domain.VillageInfo;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AspNetCore.Application.AdminDivisionInfo
{
    public class AdminDivisionAppService:IAdminDivisionAppService
    {
        private readonly IAdminDivisionDomain _adminDivisionDomain;
       
        public AdminDivisionAppService(IAdminDivisionDomain adminDivisionDomain) 
        {
            _adminDivisionDomain = adminDivisionDomain;
        }

        public List<AdminDivisionDto> GetAdminDivisions()
        {
            List<AdminDivisionDto> adminDivisions = new List<AdminDivisionDto>();
            var query = _adminDivisionDomain.Query(county=>county.GovernmentLevel==3);
            foreach(var county in query)
            {
                List<AdminDivisionDto> children = new List<AdminDivisionDto>();
                var childrenQuery = _adminDivisionDomain.Query(town => town.GovernmentLevel == 4 && town.HighLevelAreaNumber == county.AreaNumber);

                foreach(var town in childrenQuery)
                {
                    List<AdminDivisionDto> parentChildren = new List<AdminDivisionDto>();
                    var parentChildrenQuery = _adminDivisionDomain.Query(village => village.GovernmentLevel == 5 && village.HighLevelAreaNumber == town.AreaNumber);
                    foreach(var village in parentChildrenQuery)
                    {
                        parentChildren.Add(new AdminDivisionDto { Id = village.Id,AreaNumber = village.AreaNumber, GovernmentName = village.GovernmentName, Children = new List<AdminDivisionDto>() });
                    }
                    children.Add(new AdminDivisionDto { Id = town.Id,AreaNumber = town.AreaNumber, GovernmentName = town.GovernmentName,Children=parentChildren });
                }
                adminDivisions.Add(new AdminDivisionDto { Id = county.Id,AreaNumber = county.AreaNumber, GovernmentName = county.GovernmentName, Children = children });
                
            }
            return adminDivisions;
        }
        public void Add(AdminDivision AdminDivision)
        {
            AdminDivision.Id = Guid.NewGuid();
            _adminDivisionDomain.Add(AdminDivision);
        }

        public void Delete(Guid id)
        {
            _adminDivisionDomain.Delete(id);
        }

   

        public AdminDivision Get(Guid id)
        {
            return _adminDivisionDomain.GetById(id);
        }

        public void Update(AdminDivision AdminDivision)
        {
            _adminDivisionDomain.Update(AdminDivision);
        }

        public AdminDivision GetByAreaNumber(string areaNumber)
        {
            return _adminDivisionDomain.Query(a => a.AreaNumber == areaNumber).First();
        }
    }
}
