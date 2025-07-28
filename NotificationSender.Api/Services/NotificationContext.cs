using NotificationSender.Api.Interfaces;

namespace NotificationSender.Api.Services
{
    public class NotificationContext
    {
        private readonly EmailNotificationStrategy _emailNotificationStrategy;
        private readonly SmsNotificationStrategy _smsNotificationStrategy;

        public NotificationContext(EmailNotificationStrategy emailNotificationStrategy, SmsNotificationStrategy smsNotificationStrategy)
        {
            _emailNotificationStrategy = emailNotificationStrategy;
            _smsNotificationStrategy = smsNotificationStrategy;
        }

        public string SendNotification(string type, string recipient, string message)
        {
            INotificationStrategy strategy = type.ToLower() switch
            {
                "email" => _emailNotificationStrategy,
                "sms" => _smsNotificationStrategy,
                _ => throw new ArgumentException("Unsupported notification type")
            };

            return strategy.Send(recipient, message);
        }
    }
}