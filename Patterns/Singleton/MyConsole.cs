using System;

namespace Singleton
{
    public class MyConsole
    {
        private static MyConsole _instance;
        
        public static MyConsole Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new MyConsole();
                }
                return _instance;
            }
        }

        public void PrintAtPosition(char symbol, int xPosition, int yPosition)
        {
            Console.SetCursorPosition(
                xPosition <= 0 ? 0 : xPosition, 
                yPosition <= 0 ? 0 : yPosition
                );
            Console.Write(symbol);
            Console.SetCursorPosition(0, 0);
        }
    }
}