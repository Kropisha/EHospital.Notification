using System.Threading.Tasks;
using EHospital.Notification.BusinessLogic;
using EHospital.Notification.Model;
using Microsoft.AspNetCore.Mvc;

namespace EHospital.Notification.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendingEmailsController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody]Email body)
        {
            string email = body.email;
            string topic = body.topic;
            string text = body.text;

            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(email, topic, text);
            return Ok();
        }

    }
}
