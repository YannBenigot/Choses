using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Components
{
    public interface IHitbox
    {
        public bool Collision(IHitbox otherHitbox);
    }

    public interface IHitboxFactory()
    {
        public IHitbox Create(Entity entity);
    }
}
