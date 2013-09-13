using BaseAPI.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFMLBaseAPI.Graphics
{
    public class SFMLSprite: ISprite<SFMLGraphicResource, SFMLRenderTarget>
    {
        private SFML.Graphics.Sprite _sprite;

        float XScale { get; set; }
        float YScale { get; set; }
        float Rotation { get; set; }
        Color MainColor { get; set; }
        int Mode { get; set; }
        float Speed { get; set; }

        void Draw(SFMLRenderTarget target);
        void DrawShadow(SFMLRenderTarget target);
    }
}
