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
        public EntityDictionary Entities { get; set; }

        public void Draw(IRenderTarget target)
        {
            foreach (Entity entity in Entities.GetEntities<Entity>())
            {
                entity.Graphic.Draw(target);
            }
        }

        public void Update()
        {
            foreach (Trigger trigger in Triggers)
                trigger.DoShit(this);
        }

        public void When<E>(Func<E, bool> condition, Action<E> action)
            where E: Entity
        {
            Triggers.Add(new Trigger_E<E>(condition, action));
        }

        public void When<E1, E2> (Func<E1, E2, bool> condition, Action<E1, E2> action)
            where E1: Entity
            where E2: Entity
        {
            Triggers.Add(new Trigger_EE<E1, E2>(condition, action));
        }

        public static Entity FromIPlayer(IPlayer player)
        {
            return new Player(graphic: player.GetRecommendedGraphic(), position: player.GetSuggestedPosition());
        }

        public void Spawn(IEnumerable<Entity> entities)
        {
            foreach (Entity entity in entities)
                Spawn(entity);
        }

        public void Spawn(Entity entity)
        {
            Entities.Add(entity);
        }

        public abstract void Rules();
    }

    public class GameFactory<G> : IGameFactory
        where G:Game, new()
    {
        public IGame Create(IPlayer[] players)
        {
            Game game = new G();

            game.Rules();
            game.Spawn(players.Select(player => game.FromIPlayer(player)));

            return game;
        }
    }
}
