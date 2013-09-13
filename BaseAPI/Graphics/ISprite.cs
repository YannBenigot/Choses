using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAPI.Graphics
{
    public interface ISprite<Texture, RenderTarget> where Texture: IGraphicResource where RenderTarget: IRenderTarget
    {
        float XScale { get; set; }
        float YScale { get; set; }
        float Rotation { get; set; }
        Color MainColor { get; set; }
        int Mode { get; set; }
        float Speed { get; set; }

        void Draw(RenderTarget target);
        void DrawShadow(RenderTarget target);
    }
}
