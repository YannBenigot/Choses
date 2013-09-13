using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAPI.Graphics
{
    public interface IGraphicFactory<Texture, RenderTarget, Sprite> where Texture: IGraphicResource where RenderTarget: IRenderTarget where Sprite: ISprite<Texture, RenderTarget>
    {
        Sprite CreateSprite(Texture texture, float speed);
        RenderTarget[] Init();
    }
}
