using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composition
{
    public abstract class InMemoryQueryableRepositoryBase<TEntity> : IQueryableRepository<TEntity> where TEntity: Entity
    {
        private List<TEntity> Entities { get; set; }

        public InMemoryQueryableRepositoryBase()
        {
            Entities = new List<TEntity>();
        }

        public IQueryable<TEntity> All
        {
            get { return Entities.AsQueryable(); }
        }

        public TEntity GetByID(Guid entityID)
        {
            return All.SingleOrDefault(x => x.ID == entityID);
        }

        Entity IRepository.GetByID(Guid entityID)
        {
            return GetByID(entityID);
        }

        public void Add(TEntity entity)
        {
            Entities.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            Entities.Remove(entity);
        }


        public void Add(Entity entity)
        {
            Add(entity as TEntity);
        }

        public void Remove(Entity entity)
        {
            Remove(entity as TEntity);
        }
    }
}
