using Microsoft.AspNetCore.Mvc;
using NotificationSender.Api.Models;
using NotificationSender.Api.Services;

namespace NotificationSender.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly NotificationContext _notificationContext;

        public NotificationController(NotificationContext notificationContext)
        {
            _notificationContext = notificationContext;
        }

        [HttpPost("email")]
        public IActionResult SendEmail([FromBody] NotificationModel model)
        {
            var message = _notificationContext.SendNotification("email", model.Recipient, model.Message);
            return Ok(new { status = "sent", type = "email", message });
        }

        [HttpPost("sms")]
        public IActionResult SendSms([FromBody] NotificationModel model)
        {
            var message = _notificationContext.SendNotification("sms", model.Recipient, model.Message);
            return Ok(new { status = "sent", type = "sms", message });
        }
    }
}
