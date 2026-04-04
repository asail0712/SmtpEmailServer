using AetherCore.DataAccess;
using AetherCore.Utility.Attributes;
using AutoMapper;
using Common.DTO.MailMessages;
using DataAccess.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    [AutoInject(ServiceLifetime.Scoped)]
    public class MailMessagesDataAccess : MongoEntityDataAccess<MailMessagesEntity, MailMessagesDocument>, IMailMessagesDataAccess
    {
        public MailMessagesDataAccess(IMapper mapper)
            : base(mapper)
        {
        }
    }
}
