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

    class Trigger_E<E> : Trigger
        where E: Entity
    {
        Func<E, bool> Condition;
        Action<E> Action;

        public Trigger_E(Func<E, bool> condition, Action<E> action)
        {
            Condition = condition;
            Action = action;
        }

        public void DoShit(Game game)
        {
            foreach (E entity in game.Entities.GetEntities<E>())
            {
                if (Condition(entity))
                    Action(entity);
            }
        }
    }

    class Trigger_EE <E1, E2> : Trigger
        where E1: Entity
        where E2: Entity
    {
        Func<E1, E2, bool> Condition;
        Action<E1, E2> Action;

        public Trigger_EE(Func<E1, E2, bool> condition, Action<E1, E2> action)
        {
            Condition = condition;
            Action = action;
        }

        public void DoShit(Game game)
        {
            foreach (E1 e1 in game.Entities.GetEntities<E1>())
                foreach (E2 e2 in game.Entities.GetEntities<E2>())
                    if (Condition(e1, e2))
                        Action(e1, e2);
        }
    }
}
