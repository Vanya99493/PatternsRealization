using System.Collections.Generic;
using CommandPattern.Commands;

namespace CommandPattern
{
    public class Calculator
    {
        private List<Command> _history;
        
        public int Result { get; private set; }

        public Calculator()
        {
            _history = new List<Command>();
            Result = 0;
        }


        public int Sum(int firstNumber, int secondNumber)
            => PushCommand(new PlusCommand(), firstNumber, secondNumber);

        public int Minus(int firstNumber, int secondNumber)
            => PushCommand(new MinusCommand(), firstNumber, secondNumber);

        public int UndoCommand()
        {
            if (_history.Count <= 0)
                return 0;
            return Undo();
        }

        private int PushCommand(Command command, int firstNumber, int secondNumber)
        {
            int result = command.Execute(firstNumber, secondNumber);
            _history.Add(command);
            return result;
        }

        private int Undo()
        {
            int lastIndex = _history.Count - 1;
            Command command = _history[lastIndex];
            int result = command.Undo(Result);
            _history.RemoveAt(lastIndex);
            return result;
        }
    }
}