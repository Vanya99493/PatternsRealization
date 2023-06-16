using System;

namespace MediatorPattern.MediatorImplementation.Components
{
    public class DataSystem : BaseSystem
    {
        public DataSystem(IMediator mediator = null) : base(mediator) {}

        public void SaveData()
        {
            Console.WriteLine("Save data");
            _mediator.Notify(this, "save");
        }

        public void LoadData()
        {
            Console.WriteLine("Load data");
            _mediator.Notify(this, "load");
        }
    }
}