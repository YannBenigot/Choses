using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IGame
    {
        public void Draw(GameSurface surface);
        public void Update();
    }

    public interface IGameFactory
    {
        public IGame Create(Player[] players);
    }
}
