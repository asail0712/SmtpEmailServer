using AetherCore.Controller;
using AetherCore.Utility.Attributes;
using Common.DTO.MailGroups;
using Common.DTO.MailMessages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace SmtpEmailServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [CrudSummary("郵件寄送")]
    //[CrudAuthorize("AdminJwt")]
    public class MailMessagesController : GenericController<MailMessagesRequest, MailMessagesResponse, IMailMessagesService>
    {
        public MailMessagesController(IMailMessagesService service)
            : base(service, CrudOperation.None)
        {

        }

        [HttpPost("SendMail")]
        [CommonSummary("寄出郵件")]
        [SwaggerApi("App")]
        [Authorize(AuthenticationSchemes = "ServiceJwt")]
        public async Task<IActionResult> SendMail([FromBody] MailMessagesRequest request)
        {
            var serviceId = User.Claims.FirstOrDefault(c => c.Type == "ServiceId")?.Value ?? string.Empty;
            var result = await _service.SendMail(request, serviceId);

            return Ok(result);
        }
    }
}
