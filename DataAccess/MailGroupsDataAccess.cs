using AetherCore.DataAccess;
using AetherCore.Utility.Attributes;
using AutoMapper;
using Common.DTO.MailGroups;
using DataAccess.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    [AutoInject(ServiceLifetime.Scoped)]
    public class MailGroupsDataAccess : MongoEntityDataAccess<MailGroupsEntity, MailGroupsDocument>, IMailGroupsDataAccess
    {
        public MailGroupsDataAccess(IMapper mapper)
            : base(mapper)
        {
            EnsureIndexCreated("GroupName");
        }
    }
}
