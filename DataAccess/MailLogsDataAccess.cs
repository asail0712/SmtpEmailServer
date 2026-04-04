using AetherCore.DataAccess;
using AetherCore.Utility.Attributes;
using AutoMapper;
using Common.DTO.MailLogs;
using DataAccess.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    [AutoInject(ServiceLifetime.Scoped)]
    public class MailLogsDataAccess : MongoEntityDataAccess<MailLogsEntity, MailLogsDocument>, IMailLogsDataAccess
    {
        public MailLogsDataAccess(IMapper mapper)
            : base(mapper)
        {
        }
    }
}
