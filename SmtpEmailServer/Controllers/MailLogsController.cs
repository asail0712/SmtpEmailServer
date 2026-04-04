using AetherCore.Controller;
using AetherCore.Utility.Attributes;
using Common.DTO.MailLogs;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace SmtpEmailServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [CrudSummary("寄送紀錄")]
    [CrudAuthorize("AdminJwt")]
    public class MailLogsController : GenericController<MailLogsRequest, MailLogsResponse, IMailLogsService>
    {
        public MailLogsController(IMailLogsService service)
            : base(service, CrudOperation.ReadAll & CrudOperation.Read)
        {

        }
    }
}
