using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composition
{
    public interface IQueryableRepository<TEntity> : IRepository<TEntity> where TEntity: Entity
    {
        IQueryable<TEntity> All { get; }
    }
}
