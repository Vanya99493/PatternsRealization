namespace MediatorPattern.MediatorImplementation
{
    public interface IMediator
    {
        void Notify(object sender, string message);
    }
}