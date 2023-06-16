using FacadePattern.FacadeImplementation;
using System;

namespace FacadePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager(new DataModule(), new GameLogicModule(), new ViewModule());

            gameManager.LoadGame();
            Console.WriteLine();
            gameManager.PlayInGame();
            Console.WriteLine();
            gameManager.CloseGame();
            Console.ReadKey();
        }
    }
}