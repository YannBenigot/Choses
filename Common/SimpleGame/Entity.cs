using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Components;

namespace Common
{
    public class Entity
    {
        public enum EntityState {APPEARING, ALIVE, DYING, DEAD}

        public IGraphic Graphic { get; set; }
        public IHitbox Hitbox { get; set; }
        public IBehavior Behavior { get; set; }

        public bool Dead { get { return State == EntityState.DEAD; } }

        public int Layer { get; set; }

        public Vector Position;
        public EntityState State { get; set; }

        public bool Collision(Entity entity)
        {
            return Hitbox.Collision(entity.Hitbox);
        }

        public Entity(IGraphic graphic = null, IHitbox hitbox = null, IBehavior behavior = null, int layer = 1, Vector position = null, EntityState state = EntityState.ALIVE)
        {
        }
    }

    public class Player : Entity
    {
    }
}
