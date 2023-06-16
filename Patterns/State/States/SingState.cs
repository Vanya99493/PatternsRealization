using StatePattern.Player;
using System;

namespace StatePattern.States
{
    public class SingState : State
    {
        public SingState(Character character) : base(character) {}

        public override void Run()
        {
            Console.WriteLine("la-la-la");
        }
    }
}