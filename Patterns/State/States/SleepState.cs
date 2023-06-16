using StatePattern.Player;
using System;

namespace StatePattern.States
{
    public class SleepState : State
    {
        public SleepState(Character character) : base(character) {}

        public override void Run()
        {
            Console.WriteLine("...");
            _character.Energy += 60;
        }
    }
}