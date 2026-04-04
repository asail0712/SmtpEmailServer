using AetherCore.Service;
using AetherCore.Utility.Attributes;
using AutoMapper;
using Common.DTO.MailLogs;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interface;
using Service.Interface;

namespace Service
{
    [AutoInject(ServiceLifetime.Scoped)]
    public class MailLogsService : GenericService<MailLogsEntity, MailLogsRequest, MailLogsResponse, IMailLogsRepository>, IMailLogsService
    {
        public MailLogsService(IMailLogsRepository repo, IMapper mapper) 
            : base(repo, mapper)
        {
        }
    }
}
