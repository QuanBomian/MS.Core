using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Entity
{
    public abstract class EntityBase<TPrimary>
    {

        public virtual TPrimary Id { get; set; }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public abstract class EntityBase : EntityBase<Guid>
    {

    }
}
