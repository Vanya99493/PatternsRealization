namespace CommandPattern.Commands
{
    public abstract class Command
    {
        protected int _value;

        public abstract int Execute(int firstNumber, int secondNumber);

        public abstract int Undo(int number);
    }
}