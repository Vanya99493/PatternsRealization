using StatePattern.Player;
using System;

namespace StatePattern.States
{
    public class EatState : State
    {
        public EatState(Character character) : base(character) {}

        public override void Run()
        {
            Console.WriteLine("om-nom-nom");
            _character.Hunger += 100;
        }
    }
}