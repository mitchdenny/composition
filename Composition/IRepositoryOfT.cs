using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composition
{
    public interface IRepository<TEntity> : IRepository where TEntity: Entity
    {
        new TEntity GetByID(Guid entityID);
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
