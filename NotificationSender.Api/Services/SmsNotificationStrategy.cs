using NotificationSender.Api.Interfaces;

namespace NotificationSender.Api.Services
{
    public class SmsNotificationStrategy : INotificationStrategy
    {
        public string Send(string recipient, string message)
        {
            return $"📱 SMS sent to {recipient}: {message}";
        }
    }
}
