namespace CommandPattern.Commands
{
    public class PlusCommand : Command
    {
        public override int Execute(int firstNumber, int secondNumber)
        {
            _value = secondNumber;
            return firstNumber + secondNumber;
        }

        public override int Undo(int number)
        {
            return number - _value;
        }
    }
}