using NotificationSender.Api.Interfaces;

namespace NotificationSender.Api.Services
{
    public class EmailNotificationStrategy : INotificationStrategy
    {
        public string Send(string recipient, string message)
        {
            return $"📧 Email sent to {recipient}: {message}";
        }
    }
}
