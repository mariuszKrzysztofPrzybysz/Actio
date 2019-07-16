namespace Actio.Common.Events
{
    public interface IRejectedEvent : IEvent
    {
        string Code { get; }
        string Reason { get; }
    }
}
