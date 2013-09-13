using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.SimpleGame
{
    class EntityDictionary
    {
        private Dictionary<Type, List<Entity>> _entities = new Dictionary<Type, List<Entity>>();

        public void Add(Entity entity)
        {
            Type entityType = entity.GetType();
            while (entityType != typeof(Object))
            {
                ReferenceEntity(entityType, entity);
                entityType = entityType.BaseType;
            }
        }

        public void Cleanup()
        {
            foreach (List<Entity> entities in _entities.Values)
            {
                entities.RemoveAll(entity => entity.Dead);
            }
        }

        public IEnumerable<E> GetEntities<E>()
            where E : Entity
        {
            return _entities[typeof(E)].Select(e => (E)e);
        }

        void ReferenceEntity(Type entityType, Entity entity)
        {
            if (_entities.ContainsKey(entityType))
                _entities[entityType].Add(entity);
            else
                _entities[entityType] = new List<Entity>() { entity };
        }
    }
}
