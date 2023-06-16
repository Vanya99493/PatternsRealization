using MediatorPattern.MediatorImplementation;
using MediatorPattern.MediatorImplementation.Components;
using System;

namespace MediatorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataSystem dataSystem = new DataSystem();
            UpdateSystem updateSystem = new UpdateSystem();
            ViewSystem viewSystem = new ViewSystem();

            Mediator mediator = new Mediator(dataSystem, updateSystem, viewSystem);

            Console.WriteLine("Load program");
            dataSystem.LoadData();

            Console.WriteLine();

            Console.WriteLine("Update program's data");
            updateSystem.UpdateData();

            Console.WriteLine();

            Console.WriteLine("Save progress");
            dataSystem.SaveData();

            Console.ReadKey();
        }
    }
}