using System;
using System.Collections.Generic;
using System.Text;

namespace gestcor.Domain.Base
{
    public abstract class BaseEntity
    {

    }

    public abstract class Entity : BaseEntity, IEntity
    {
        public virtual int Id { get; set; }
    }
}
