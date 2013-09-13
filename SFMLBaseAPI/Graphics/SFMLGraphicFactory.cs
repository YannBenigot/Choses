using BaseAPI.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLBaseAPI.Graphics
{
    class SFMLGraphicFactory: IGraphicFactory<SFMLGraphicResource, SFMLRenderTarget, SFMLSprite>
    {
        public SFMLSprite CreateSprite(SFMLGraphicResource resource, float speed)
        {
        }

        public SFMLRenderTarget[] Init();
    }
}
