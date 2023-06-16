using StatePattern.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public abstract class State
    {
        protected Character _character;

        public State(Character character) 
        {
            _character = character;
        }

        abstract public void Run();
    }
}