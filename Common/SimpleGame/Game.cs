using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.SimpleGame
{
    public abstract class Game: IGame
    {
        private readonly Entity[] Players;
        private readonly List<Trigger> Triggers;
        public Dictionary<string, List<Entity>> Entities { get; set; }

        public void Draw(RenderTarget target)
        {
            foreach (Entity entity in Entities["All"])
            {
                entity.Graphic.Draw(target);
            }
        }

        public void Update()
        {
            foreach (Trigger trigger in Triggers)
                trigger.DoShit(this);
        }

        public void When(string kind, Func<Entity, bool> condition, Action<Entity> action)
        {
            Triggers.Add(new Trigger_E(kind, condition, action));
        }

        public void When(string k1, string k2, Func<Entity, Entity, bool> condition, Action<Entity, Entity> action)
        {
            Triggers.Add(new Trigger_EE(k1, k2, condition, action));
        }

        public abstract void Rules();
    }

    public class GameFactory<G> : IGameFactory
        where G:Game, new()
    {
        public IGame Create(IPlayer[] players)
        {
            Game game = new G();
            game.Entities["Player"] = players.Select(player => Entity.FromIPlayer(player)).ToList();
            game.Entities["All"] = new List<Entity>(game.Entities["Player"]);
            game.Rules();
            return game;
        }
    }
}
