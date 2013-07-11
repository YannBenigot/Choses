using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SimpleGame;

namespace TestGame
{
    public class TestGame: Game
    {
        public void Rules()
        {
            When("Player", player => player.Position.X >= 320, player => player.Position.Y = 320);
        }
    }
}
