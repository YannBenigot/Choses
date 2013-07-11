using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Components;

namespace Common
{
    public interface IPlayer
    {
        public enum KeyType {A, B, UP, DOWN, LEFT, RIGHT};
        public struct KeyEvent
        {
            public enum Status { Pressed, Released };
            public KeyType Key;
        }

        public bool IsKeyPressed(KeyType key);
        public List<KeyEvent> GetLastEvents();

        public IGraphic GetRecommendedGraphic();
    }
}
