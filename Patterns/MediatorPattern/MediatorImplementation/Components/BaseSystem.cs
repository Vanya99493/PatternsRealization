namespace MediatorPattern.MediatorImplementation.Components
{
    public class BaseSystem
    {
        protected IMediator _mediator;

        public BaseSystem(IMediator mediator = null)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}