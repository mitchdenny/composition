using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composition
{
    public interface IRepository
    {
        Entity GetByID(Guid entityID);
        void Add(Entity entity);
        void Remove(Entity entity);
    }
}
