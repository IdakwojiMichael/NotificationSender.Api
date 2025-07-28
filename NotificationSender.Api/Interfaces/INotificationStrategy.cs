namespace NotificationSender.Api.Interfaces
{
    public interface INotificationStrategy
    {
        string Send(string recipient, string message);
    }
}
