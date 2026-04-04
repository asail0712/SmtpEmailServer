using AetherCore.Controller;
using AetherCore.Utility.Attributes;
using Common.DTO.MailGroups;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace SmtpEmailServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [CrudSummary("郵件寄送群組")]
    //[CrudAuthorize("AdminJwt")]
    public class MailGroupsController : GenericController<MailGroupsRequest, MailGroupsResponse, IMailGroupsService>
    {
        public MailGroupsController(IMailGroupsService service)
            : base(service, CrudOperation.All)
        {

        }
    }
}
