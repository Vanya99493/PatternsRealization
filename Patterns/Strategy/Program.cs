using System;
using System.Threading;
using Strategy.EnemyImplementation;
using Strategy.Strategy;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy(new FourDirectionMovingStrategy(), new VectorInt2(3, 3), '@');

            while (true)
            {
                Console.Clear();
                enemy.MoveAndPrint();
                Thread.Sleep(500);
            }
        }
    }
}