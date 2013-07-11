using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Components
{
    public interface IGraphic
    {
        public void Draw(RenderTarget target);
    }

    public interface IGraphicFactory
    {
        public IGraphic Create(Entity entity);
    }
}
