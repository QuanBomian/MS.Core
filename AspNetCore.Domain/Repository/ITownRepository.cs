﻿using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.Repository
{
    public interface ITownRepository:IRepository<Town,Guid>
    {
    }
}
