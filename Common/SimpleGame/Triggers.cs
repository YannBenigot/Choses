using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.SimpleGame
{
    abstract class Trigger
    {
        public abstract void DoShit(Game game);
    }

    class Trigger_E : Trigger
    {
        Func<Entity, bool> Condition;
        Action<Entity> Action;
        string Kind;

        public Trigger_E(string kind, Func<Entity, bool> condition, Action<Entity> action)
        {
            Condition = condition;
            Action = action;
            Kind = kind;
        }

        public void DoShit(Game game)
        {
            foreach (Entity entity in game.Entities[Kind])
            {
                if (Condition(entity))
                    Action(entity);
            }
        }
    }

    class Trigger_EE : Trigger
    {
        Func<Entity, Entity, bool> Condition;
        Action<Entity, Entity> Action;
        string Kind1, Kind2;

        public Trigger_EE(string kind1, string kind2, Func<Entity, Entity, bool> condition, Action<Entity, Entity> action)
        {
            Condition = condition;
            Action = action;
            Kind1 = kind1;
            Kind2 = kind2;
        }

        public void DoShit(Game game)
        {
            foreach (Entity e1 in game.Entities[Kind1])
                foreach (Entity e2 in game.Entities[Kind2])
                    if (Condition(e1, e2))
                        Action(e1, e2);
        }
    }
}
