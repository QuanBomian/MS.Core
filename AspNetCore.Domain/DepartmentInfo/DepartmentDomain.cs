using AspNetCore.Domain.DepartmentInfo.Dto;
using AspNetCore.Domain.Repository;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore.Domain.DepartmentInfo
{
    public class DepartmentDomain : Domain<Department, Guid>, IDepartmentDomain
    {
        public DepartmentDomain(IDepartmentRepository repository) : base(repository) { }

        public List<Department> Get(DepartmentQueryDto condition)
        {
            IQueryable<Department> query = _repository.Query();
            if (condition.DepartmentName != null && condition.DepartmentName.Trim() != "")
            {
                query = query.Where(Department => Department.DepartmentName.Contains(condition.DepartmentName));
            }
            if (condition.Address != null && condition.Address.Trim() != "")
            {
                query = query.Where(Department => Department.Address.Contains(condition.Address));
            }
            if (condition.DepartmentCode != null && condition.DepartmentCode.Trim() != "")
            {
                query = query.Where(Department => Department.DepartmentCode.Contains(condition.DepartmentCode));
            }
            if (condition.Email != null && condition.Email.Trim() != "")
            {
                query = query.Where(Department => Department.Email.Contains(condition.Email));
            }
            if (condition.Fax != null && condition.Fax.Trim() != "")
            {
                query = query.Where(Department => Department.Fax.Contains(condition.Fax));
            }
            if (condition.ContactPhone != null && condition.ContactPhone.Trim() != "")
            {
                query = query.Where(Department => Department.ContactPhone.Contains(condition.ContactPhone));
            }
            if (condition.PrincipalName != null && condition.PrincipalName.Trim() != "")
            {
                query = query.Where(Department => Department.PrincipalName.Contains(condition.PrincipalName));
            }
            if (condition.Notes != null && condition.Notes.Trim() != "")
            {
                query = query.Where(Department => Department.Notes.Contains(condition.Notes));
            }

            return query.ToList();
        }
    }
}
