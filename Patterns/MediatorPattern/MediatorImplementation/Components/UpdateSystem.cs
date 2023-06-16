using System;

namespace MediatorPattern.MediatorImplementation.Components
{
    public class UpdateSystem : BaseSystem
    {
        public UpdateSystem(IMediator mediator = null) : base(mediator) {}

        public void SetData()
        {
            Console.WriteLine("Set data");
            _mediator.Notify(this, "set");
        }

        public void UpdateData()
        {
            Console.WriteLine("Update data");
            _mediator.Notify(this, "update");
        }
    }
}