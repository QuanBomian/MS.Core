﻿using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Entity;

namespace AspNetCore.Domain.Repository
{
    public interface IRoleRepository:IRepository<Role,Guid>
    {
    }
}
