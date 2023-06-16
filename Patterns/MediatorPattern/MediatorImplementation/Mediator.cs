using MediatorPattern.MediatorImplementation.Components;
using System;

namespace MediatorPattern.MediatorImplementation
{
    public class Mediator : IMediator
    {
        private DataSystem _dataSystem;
        private UpdateSystem _updateSystem;
        private ViewSystem _viewSystem;

        public Mediator(DataSystem dataSystem, UpdateSystem updateSystem, ViewSystem viewSystem)
        {
            _dataSystem = dataSystem;
            _updateSystem = updateSystem;
            _viewSystem = viewSystem;

            _dataSystem.SetMediator(this);
            _updateSystem.SetMediator(this);
            _viewSystem.SetMediator(this);
        }

        public void Notify(object sender, string message)
        {
            switch (message)
            {
                case "save":
                    Console.WriteLine("Data was saved");
                    break;
                case "load":
                    Console.WriteLine("Data was loaded");
                    _updateSystem.SetData();
                    break;
                case "set":
                    Console.WriteLine("Data was established");
                    _viewSystem.ViewData();
                    break;
                case "update":
                    Console.WriteLine("Data was updated");
                    _dataSystem.SaveData();
                    _viewSystem.ViewData();
                    break;
                case "view":
                    Console.WriteLine("Data was showed");
                    break;
                default:
                    break;
            }
        }
    }
}