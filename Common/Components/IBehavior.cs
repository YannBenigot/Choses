using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Components
{
    public interface IBehavior
    {
        public void Update(Game game);
    }

    public interface IBehaviorFactory
    {
        public IBehavior Create(Entity entity);
    }
}
