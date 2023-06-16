using System;

namespace MediatorPattern.MediatorImplementation.Components
{
    public class ViewSystem : BaseSystem
    {
        public ViewSystem(IMediator mediator = null) : base(mediator) {}

        public void ViewData()
        {
            Console.WriteLine("View data");
            _mediator.Notify(this, "view");
        }
    }
}