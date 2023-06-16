using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using StatePattern.States;

namespace StatePattern.Player
{
    public class Character
    {
        public int Hunger;
        public int Energy;

        private Dictionary<string, State> _states;
        private State _currentState;

        public Character()
        {
            Hunger = 150;
            Energy = 100;

            _states = new Dictionary<string, State>()
            {
                { "Eat", new EatState(this) },
                { "Sleep", new SleepState(this) },
                { "Sing", new SingState(this) }
            };

            _currentState = _states["Sing"];
            Update(200);
        }

        public void Update(int deltaTime)
        {
            new Thread(() =>
            {
                while (true)
                {
                    Hunger -= 10;
                    Energy -= 10;

                    _currentState.Run();

                    if (Hunger < 20)
                    {
                        ChangeState(_states["Eat"]);
                    }
                    else if (Energy < 20)
                    {
                        ChangeState(_states["Sleep"]);
                    }
                    else
                    {
                        ChangeState(_states["Sing"]);
                    }
                    Thread.Sleep(deltaTime);
                }
            }).Start();
        }

        public void ChangeState(State newState)
        {
            _currentState = newState;
        }
    }
}